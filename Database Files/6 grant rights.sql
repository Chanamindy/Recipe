use RecipeWebsiteDB
go 

--select concat('grant execute on ', r.ROUTINE_NAME,' to recipeapprole')
--from INFORMATION_SCHEMA.ROUTINES r
--where r.ROUTINE_NAME not like '%gener%'
--and r.ROUTINE_NAME not like '%colname%'

grant execute on RecipeDelete to recipeapprole
grant execute on CuisineGet to recipeapprole
grant execute on TotalNumCaloriesPerMeal to recipeapprole
grant execute on RecipeGet to recipeapprole
grant execute on RecipeInfo to recipeapprole
grant execute on RecipeUpdate to recipeapprole
grant execute on AutoCreateCookbook to recipeapprole
grant execute on ChangeRecipeStatus to recipeapprole
grant execute on CloneRecipe to recipeapprole
grant execute on CookbookDelete to recipeapprole
grant execute on CookbookListGet to recipeapprole
grant execute on CookbookRecipeDelete to recipeapprole
grant execute on CookbookRecipesGet to recipeapprole
grant execute on CookbookRecipeUpdate to recipeapprole
grant execute on CookbookUpdate to recipeapprole
grant execute on CourseDelete to recipeapprole
grant execute on CourseGet to recipeapprole
grant execute on CourseUpdate to recipeapprole
grant execute on CuisineDelete to recipeapprole
grant execute on CuisineUpdate to recipeapprole
grant execute on DashboardSummaryGet to recipeapprole
grant execute on IngredientDelete to recipeapprole
grant execute on IngredientGet to recipeapprole
grant execute on IngredientUpdate to recipeapprole
grant execute on MealListGet to recipeapprole
grant execute on MeasurementDelete to recipeapprole
grant execute on MeasurementGet to recipeapprole
grant execute on MeasurementUpdate to recipeapprole
grant execute on RecipeDirectionDelete to recipeapprole
grant execute on RecipeDirectionsGet to recipeapprole
grant execute on RecipeDirectionUpdate to recipeapprole
grant execute on RecipeIngredientDelete to recipeapprole
grant execute on RecipeIngredientsGet to recipeapprole
grant execute on RecipeIngredientUpdate to recipeapprole
grant execute on UserStaffDelete to recipeapprole
grant execute on UserNameGet to recipeapprole
grant execute on UserStaffGet to recipeapprole
grant execute on UserStaffUpdate to recipeapprole