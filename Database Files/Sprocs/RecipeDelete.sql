create or alter procedure dbo.RecipeDelete(
    @RecipeId int, 
    @Message varchar(500) = '' output
)
as 
begin 
    declare @Return int = 0

    if exists(select * from Recipe r where r.RecipeId =  @RecipeId and (r.RecipeStatus = 'Published' or (r.RecipeStatus = 'Archived' and (datediff(day, r.DateArchived, getdate()) < 30))))
    begin 
--AS Message is incorrect, should say OR isntead of AND
        select @Return = 1, @Message = 'Cannot delete recipe because the recipe is published and has not been archived for more than 30 days.'
        goto finished 
    end 

    begin try
        begin tran 
            delete RecipeIngredient where RecipeId = @RecipeId
            delete RecipeDirection where RecipeId = @RecipeId
            delete Recipe where RecipeId = @RecipeId
        commit 
    end try 
    begin catch 
        rollback; 
        throw 
    end catch 

    finished:
    return @Return
end