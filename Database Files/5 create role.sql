use RecipeWebsiteDB
go
drop role if exists recipeapprole
go
create role recipeapprole
go
alter role recipeapprole add member recipeappadmin_user
go