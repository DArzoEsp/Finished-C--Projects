string? userRole;
bool validRole = false;

Console.WriteLine("Input role name (Administrator, Manager, or User): ");

do {
    userRole = Console.ReadLine();

    if(userRole != null) {
        string role = userRole.Trim();
        role = role.ToLower();

        if (role == "administrator" || role == "manager" || role == "user") {
            Console.WriteLine($"Your input value ({userRole}) has been accepted.");
            validRole = true;
        } else 
            Console.WriteLine($"The role name that you entered, \"{userRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (validRole == false);