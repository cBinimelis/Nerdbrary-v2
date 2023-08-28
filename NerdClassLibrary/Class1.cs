using Microsoft.EntityFrameworkCore;

namespace NerdClassLibrary
{
    public class Class1
    {

    }
}

//dotnet ef dbcontext scaffold "Data Source=localhost;Initial Catalog=bd_biblioteca;Persist Security Info=True;User ID=sa;Password=crislyn;" Microsoft.EntityFrameworkCore.SqlServer -o Modelos



//Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_biblioteca;Persist Security Info=True;User ID=sa;Password=crislyn;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Modelos