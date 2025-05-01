declare @RecipeId int 

select top 1 @RecipeId = r.RecipeId 
from Recipe r 
left join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
left join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
left join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
left join CookBookRecipe cbr 
on r.RecipeId = cbr.RecipeId
where ri.RecipeIngredientId is not null 
and rd.RecipeDirectionId is not null
--and mcr.MealCourseRecipeId is null 
and cbr.CookbookRecipeId is null
order by r.RecipeId

select top 1 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select top 1 'Recipe Ingredient', ri.RecipeId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @RecipeId
union select top 1 'Recipe Direction', rd.RecipeId, rd.Instructions from RecipeDirection rd where rd.RecipeId = @RecipeId
union select top 1 'Meal Course Recipe', mcr.RecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on mc.MealId = m.MealId where mcr.RecipeId = @RecipeId
union select top 1 'Cook Book Recipe', cbr.RecipeId, cb.CookBookName from CookBookRecipe cbr join CookBook cb on cbr.CookBookId = cb.CookBookId where cbr.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select top 1 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select top 1 'Recipe Ingredient', ri.RecipeId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @RecipeId
union select top 1 'Recipe Direction', rd.RecipeId, rd.Instructions from RecipeDirection rd where rd.RecipeId = @RecipeId
union select top 1 'Meal Course Recipe', mcr.RecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on mc.MealId = m.MealId where mcr.RecipeId = @RecipeId
union select top 1 'Cook Book Recipe', cbr.RecipeId, cb.CookBookName from CookBookRecipe cbr join CookBook cb on cbr.CookBookId = cb.CookBookId where cbr.RecipeId = @RecipeId