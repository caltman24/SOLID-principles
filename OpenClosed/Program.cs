List<EmployeeModel> employees = new()
{
    new() {
        Name = "Gary",
    },
    new() {
        Name = "Allen",
        Type = EmployeeType.Manager
    },
    new() {
        Name = "Corbyn",
        Type = EmployeeType.Owner
    }
};


foreach (var employee in employees)
{
    employee.PrintDetails();
}


class EmployeeModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public EmployeeType Type { get; set; } = EmployeeType.Base;

    //FIXME: If i want to add a new EmployeeType, i have to change the code in this class and the EmployeeType Enum. It is not following the open/closed principle. (Open for extension. Closed for modification)
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        switch (Type)
        {
            case EmployeeType.Base:
                Console.WriteLine("Hello Base Employee. Sucks to be you");
                break;
            case EmployeeType.Manager:
                Console.WriteLine("Hello Managerrr. Your life still sucks but hey... you make more money am i right?");
                break;
            case EmployeeType.Owner:
                Console.WriteLine("Hello my ownerrrrr:) How can i help you today?");
                break;
        }
        Console.WriteLine();
    }
}

enum EmployeeType
{
    Base,
    Manager,
    Owner
}
