--AS Amazing job!! 100%
use RecipeWebsiteDB
go 
drop table if exists dbo.CookBookRecipe 
drop table if exists dbo.CookBook 
drop table if exists dbo.MealCourseRecipe 
drop table if exists dbo.MealCourse 
drop table if exists dbo.Course 
drop table if exists dbo.Meal
drop table if exists dbo.RecipeDirection 
drop table if exists dbo.RecipeIngredient
drop table if exists dbo.Measurement
drop table if exists dbo.Recipe 
drop table if exists dbo.UserStaff
drop table if exists dbo.Ingredient
drop table if exists dbo.Cuisine
go 
create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(35) not null 
        constraint ck_Cuisine_Cuisine_Type_cannot_be_blank check(CuisineType <> '')
        constraint u_Cuisine_Cuisine_Type unique 
)
go 
create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(50) not null 
        constraint ck_Ingredient_Ingredient_Name_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_Ingredient_Name unique,
    IngredientPictureCode as concat('Ingredient', '_', replace(IngredientName, ' ', '_'), '.jpg')
)
go 
create table dbo.UserStaff(
    UserStaffId int not null identity primary key,
    UserFirstName varchar(30) not null constraint ck_User_First_Name_cannot_be_blank check(UserFirstName <> ''),
    UserLastName varchar(30) not null constraint ck_User_Last_Name_cannot_be_blank check(UserLastName <> ''),
    UserName varchar(50) not null 
        constraint ck_User_User_Name_cannot_be_blank check(UserName <> '')
        constraint u_User_User_Name unique
)
go 
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    UserStaffId int not null constraint f_UserStaff_Recipe foreign key references UserStaff(UserStaffId),
    RecipeName varchar(50) not null 
        constraint ck_Recipe_Name_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_Name unique,
    Calorie int not null constraint ck_Recipe_Calorie_must_be_greater_than_0 check(Calorie > 0),
    DateDrafted datetime not null constraint ck_Recipe_Date_Drafted_must_be_between_January_2022_and_the_current_date check((DateDrafted >= '2022-01-01') and (DateDrafted <= getdate())) default getdate(),
    DatePublished datetime null constraint ck_Recipe_Date_Published_must_be_between_January_2022_and_the_current_date check((DatePublished >= '2022-01-01') and (DatePublished <= getdate())),
    DateArchived datetime null constraint ck_Recipe_Date_Archived_must_be_between_January_2022_and_the_current_date check((DateArchived >= '2022-01-01') and (DateArchived <= getdate())),
    RecipeStatus as case 
        when DatePublished is null and DateArchived is null then 'Drafted'
        when DatePublished is not null and DateArchived is null then 'Published'
        else 'Archived'
        end,
    RecipePictureCode as concat('Recipe', '_', replace(RecipeName, ' ', '_'), '.jpg'),
        constraint ck_Date_Published_is_between_DateDrafted_and_DateArchived check(DatePublished between DateDrafted and DateArchived),
        constraint ck_Date_Drafted_is_before_DatePublished_and_before_DateArchived check(DateDrafted <= DatePublished and DateDrafted <= DateArchived)
)
go 
create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementType varchar(25) not null 
        constraint ck_Measurement_Measurement_Type_cannot_be_blank check(MeasurementType <> '')
        constraint ck_Measurement_Measurement_Type unique
)
go 
create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementId int null constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId),
    Amount decimal(5,2) not null constraint ck_RecipeIngredient_Amount_must_be_greater_than_0 check(Amount > 0),
    IngredientSequence int not null constraint ck_RecipeIngredient_Ingredient_Sequence_must_be_greater_than_0 check(IngredientSequence > 0),
        constraint u_RecipeIngredient_RecipeId_IngredientSequence unique(RecipeId, IngredientSequence),
        constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId, IngredientId)
)
go 
create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    RecipeDirectionSequence int not null constraint ck_RecipeDirection_RecipeDirectionSequence_must_be_greater_than_0 check(RecipeDirectionSequence > 0),
    Instructions varchar(300) not null constraint ck_RecipeDirection_Instructions_cannot_be_blank check(Instructions <> ''),
        constraint u_RecipeDirection_RecipeId_RecipeDirectionSequence unique(RecipeId, RecipeDirectionSequence)
)
go
create table dbo.Meal(
    MealId int not null identity primary key,
    UserStaffId int not null constraint f_UserStaff_Meal foreign key references UserStaff(UserStaffId),
    MealName varchar(30) not null 
        constraint ck_Meal_Meal_Name_cannot_be_blank check(MealName <> '')
        constraint u_Meal_Meal_Name unique,
    MealStatus bit not null,
    DateCreated date not null constraint ck_Meal_Date_Created_must_be_between_January_2022_and_the_current_date check(DateCreated between '2022-01-01' and getdate()),
    MealPictureCode as concat('Meal', '_', replace(MealName, ' ', '_'), '.jpg')
)
create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(30) not null 
        constraint ck_Course_Course_Name_cannot_be_blank check(CourseName <> '')
        constraint u_Course_Course_Name unique,
    CourseSequence int not null 
        constraint ck_Course_Course_Sequence_must_be_greater_than_0 check(CourseSequence > 0)
        constraint u_Course_Course_Sequence unique
)
go 
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
        constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)
go
create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    Main bit not null,
        constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)
go 
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UserStaffId int not null constraint f_UserStaff_CookBook foreign key references UserStaff(UserStaffId),
    CookbookName varchar(30) not null 
        constraint ck_CookBook_CookBook_Name_cannot_be_blank check(CookBookName <> '')
        constraint u_CookBook_CookBook_Name unique,
    CookbookPrice decimal(5,2) not null constraint ck_Cookbook_Price_must_be_greater_than_0 check(CookbookPrice > 0),
    CookbookStatus bit not null,
    DateCreated date not null constraint ck_CookBook_Date_Created_must_be_between_January_2022_and_the_current_date check(DateCreated between '2022-01-01' and getdate()),
    CookbookPictureCode as concat('CookBook', '_', replace(CookBookName, ' ', '_'), '.jpg')
)
go 
create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_CookBook_CookBookRecipe foreign key references CookBook(CookBookId),
    RecipeId int not null constraint f_Recipe_CookBookRecipe foreign key references Recipe(RecipeId),
    RecipeSequence int not null constraint ck_CookBookRecipe_Recipe_Sequence_must_be_greater_than_0 check(RecipeSequence > 0),
        constraint u_CookBookRecipe_CookBookId_RecipeId unique(CookBookId, RecipeId)
)
go 