namespace Dewey_Decimal_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the application configuration, which can include settings like high DPI and default fonts.
            ApplicationConfiguration.Initialize();

            try
            {
                // Run the application, starting with the "Home" form.
                Application.Run(new Home());
            }
            catch (System.NullReferenceException)
            {
                // Handle a potential null reference exception if it occurs.
                // This exception is thrown when there is an attempt to dereference a null object.
                throw;
            }
        }
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
