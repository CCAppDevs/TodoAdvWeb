using TodoAdvWeb.Server.Data;

namespace TodoAdvWeb.Server.Models
{
    public class SeedData
    {
        public static async Task EnsurePopulated(IServiceProvider services)
        {
            // get a handle to the context
            TodoContext context = services.GetService<TodoContext>();

            // check if the context is valid
            if (context == null)
            {
                throw new NullReferenceException("No Context available");
            }

            // check if there is data in the database
            if (context.Todos.Any())
            {
                // if there is, abort (we don't need to seed)
                return;
            } else
            {
                throw new Exception("No data available");
            }



            // if there is not any data


            // start populating the database with data

        }
    }
}
