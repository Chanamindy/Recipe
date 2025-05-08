create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(130)
as 
begin 
    declare @value varchar(130) = ''

    select @value = concat(r.RecipeName, ' (', c.CuisineType, ') has ', max(isnull(ri.IngredientSequence, 0)), ' ingredients and ', max(isnull(rd.RecipeDirectionSequence, 0)), ' steps.')
    from Recipe r 
    left join Cuisine c 
    on r.CuisineId = c.CuisineId
    left join RecipeIngredient ri 
    on r.RecipeId = ri.RecipeId
    left join RecipeDirection rd 
    on r.RecipeId = rd.RecipeId
    where r.RecipeId = @Recipeid
    group by r.RecipeName, c.CuisineType

    return @value
end 
go

select RecipeInfo = dbo.RecipeInfo(r.RecipeId)
from Recipe r