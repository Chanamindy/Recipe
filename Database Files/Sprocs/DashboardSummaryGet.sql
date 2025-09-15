create or alter proc dbo.DashboardSummaryGet(
	@Message varchar(500) = '' output
)
as 
begin
	select Type = 'Recipes', Number = count(r.RecipeId)
	from Recipe r 
	union select 'Meals', count(m.MealId) 
	from Meal m 
	union select 'Cookbooks', count(CookbookId)
	from Cookbook cb 
	order by Type desc
end
go

exec DashboardSummarGet