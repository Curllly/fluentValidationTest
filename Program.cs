// See https://aka.ms/new-console-template for more information

using Validation;

Student student = new Student()
{
    Age = 55,
    Course = 5,
    Name = "Игорь",
    Surname = "Павлов",
};

var validator = new StudentValidation();
var validationResult = validator.Validate(student);
if (!validationResult.IsValid)
{
    foreach (var error in validationResult.Errors)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}
