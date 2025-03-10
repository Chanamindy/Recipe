--AS Amazing job! Please see 2 comments, no need to resubmit. 
/*
Cuisine
    CuisineId pk
    CuisineType varchar(35) not null not blank unique
Ingredients
    IngredientId pk
    Ingredient Name varchar(50) not null not blank unique
    IngredientPictureCode as concat('Ingredient', '_', replace(IngredientName, ' ', '_'), '.jpg')
User
    UserId pk
    UserFirstName varchar(30) not null not blank
    UserLastName varchar(30) not null not blank
    UserName varchar(50) not null not blank unique
Recipe
    RecipeId pk
    RecipeName varchar(50) not null not blank unique
    CuisineId fk
    Calorie int not null  greater than 0
    DateDrafted datetime not null
    DatePublished datetime null constraint between January 2022 and the current date
    DateArchived datetime null constraint between January 2022 and the current date
    RecipeStatus as case 
        when datePublished and DateArchived null then drafted
        When DateArchived null and DatePublished not null then Published 
--AS This can just be an else.
        else Archived
    UserId fk
    RecipePictureCode as concat('Recipe', '_', replace(RecipeName, ' ', '_'), '.jpg')
--AS You can write the first 2 of these constraints in one using and.
        constraint DateDrafted < DatePublished
        constraint DateDrafted < DateArchived
        constraint DatePublished < DateArchived
Measurement
    MeasurementId pk
    MeasurementType varchar(25) not null not blank unique
RecipeIngredient
    RecipeIngredientId pk
    RecipeId fk
    IngredientId fk
    Amount int not null greater than 0
    MeasurementType fk
    IngredientSequence int not null greater than 0
        constraint RecipeId, IngredientSequence unique
        constraint RecipeId, IngredientId unique
RecipeDirections
    RecipeDirectionsId pk
    Recipeid fk
    Sequence int not null greater than 0 
    Instructions varchar(200) not null not blank
        constraint RecipeId and Sequence together must be unique
Meal
    MealId pk
    MealName varchar(30) not null not blank unique
    MealStatus bit not null 
    DateCreated date constraint between January 2022 and current date
    UserId fk
    MealPictureCode as concat('Meal', '_', replace(MealName, ' ', '_'), '.jpg')
Course
    CourseId pk
    CourseName varchar(30) not null not blank unique
    CourseSequence int not null greater than 0
MealCourse
    MealCourseId pk
    MealId fk
    CourseId fk
        constraint MealId and CourseId unique
MealCourseRecipe
    MealCourseRecipeId pk
    MealCourseId fk
    RecipeId fk
    Main bit not null
        constraint MealCourseId, RecipeId unique
CookBook
    CookBookId pk
    CookBookName varchar(30) not null not blank unique
    CookBookPrice decimal(5,2)
    CookBookStatus bit not null
    DateCreated date constraint has to be betwee January 2022 and current date
    UserId fk
    CookBookPictureCode as concat('CookBook', '_', replace(CookBookName, ' ', '_'), '.jpg')
CookBookRecipes
    CookBookRecipeId pk
    CookBookId fk
    RecipeId fk
    Sequence int not null greater than 0
        constraint CookBookId, RecipeId unique
*/