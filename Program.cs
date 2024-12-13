using sea;

namespace sea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fishmanager system = new Fishmanager();
            system.Start();
        }
    }
}
internal class Fishmanager
{

    public void Start()
    {
        string prompt = @"
███████╗███████╗ █████╗     ██╗      █████╗     ██╗   ██╗██╗███████╗
██╔════╝██╔════╝██╔══██╗    ██║     ██╔══██╗    ██║   ██║██║██╔════╝
███████╗█████╗  ███████║    ██║     ███████║    ██║   ██║██║█████╗  
╚════██║██╔══╝  ██╔══██║    ██║     ██╔══██║    ╚██╗ ██╔╝██║██╔══╝  
███████║███████╗██║  ██║    ███████╗██║  ██║     ╚████╔╝ ██║███████╗
╚══════╝╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═╝╚══════╝
                             /`·.¸
                             /¸...¸`:·
                         ¸.·´  ¸   `·.¸.·´)
                        : © ):´;      ¸  {
                         `·.¸ `·  ¸.·´\`·¸)
                             `\\´´\¸.·´

    Welcome to Sea la Vie's Mini-Pisciculture Inventory System!
   Use the UP and Down arrow keys to navigate through the choices.
   Press ENTER to select an option.
";
        string[] options = { "Start", "About", "Exit" };
        Scroller starting = new Scroller(prompt, options);
        int index = starting.Navigate();


        switch (index)
        {
            case 0:
                StartProgram();
                break;
            case 1:
                AboutProgram();
                break;
            case 2:
                ExitProgram();
                break;
        }
    }
    private void StartProgram()
    {
        Fishfarmdetails FM = new Fishfarmdetails();
        FM.Menu();
    }
    private void AboutProgram()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("| This program was created by:          |");
        Console.WriteLine("| Nesserain C. De la Cruz               |");
        Console.WriteLine("| BSCpE-2                               |");
        Console.WriteLine("| Press any key to return to menu.      |");
        Console.WriteLine("-----------------------------------------");
        Console.ReadKey(true);
        Start();

    }
    private void ExitProgram()
    {
        Console.WriteLine("\nThank you for using the program!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
        Environment.Exit(0);
    }

}
internal class Fishfarmdetails
{
    public void Menu()
    {
        string prompt = @"
███████╗███████╗ █████╗     ██╗      █████╗     ██╗   ██╗██╗███████╗
██╔════╝██╔════╝██╔══██╗    ██║     ██╔══██╗    ██║   ██║██║██╔════╝
███████╗█████╗  ███████║    ██║     ███████║    ██║   ██║██║█████╗  
╚════██║██╔══╝  ██╔══██║    ██║     ██╔══██║    ╚██╗ ██╔╝██║██╔══╝  
███████║███████╗██║  ██║    ███████╗██║  ██║     ╚████╔╝ ██║███████╗
╚══════╝╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═╝╚══════╝
                             /`·.¸
                             /¸...¸`:·
                         ¸.·´  ¸   `·.¸.·´)
                        : © ):´;      ¸  {
                         `·.¸ `·  ¸.·´\`·¸)
                             `\\´´\¸.·´

             A Mini-Pisciculture Inventory System!
  Use the UP and Down arrow keys to navigate through the choices.
  Press ENTER to select an option.

*******Main Menu*******";
        string[] options = { "Fish Farm", "Sales Report", "Return" };

        while (true)
        {
            Scroller starting = new Scroller(prompt, options);
            int index = starting.Navigate();

            switch (index)
            {
                case 0:
                    Fishmanagementsystem fm = new Fishmanagementsystem();
                    fm.Main();
                    break;
                case 1:
                    FishSalesmanager fs = new FishSalesmanager();
                    fs.Sale();
                    break;
                case 2:
                    Fishmanager Fm = new Fishmanager();
                    Fm.Start();
                    break;
            }

        }
    }
}
internal class FishSalesmanager
{
    public void Sale()
    {
        var farm = new FishFarm();
        FishFarm fishFarm = new FishFarm();
        string prompt = @"
███████╗███████╗ █████╗     ██╗      █████╗     ██╗   ██╗██╗███████╗
██╔════╝██╔════╝██╔══██╗    ██║     ██╔══██╗    ██║   ██║██║██╔════╝
███████╗█████╗  ███████║    ██║     ███████║    ██║   ██║██║█████╗  
╚════██║██╔══╝  ██╔══██║    ██║     ██╔══██║    ╚██╗ ██╔╝██║██╔══╝  
███████║███████╗██║  ██║    ███████╗██║  ██║     ╚████╔╝ ██║███████╗
╚══════╝╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═╝╚══════╝
                             /`·.¸
                             /¸...¸`:·
                         ¸.·´  ¸   `·.¸.·´)
                        : © ):´;      ¸  {
                         `·.¸ `·  ¸.·´\`·¸)
                             `\\´´\¸.·´

             A Mini-Pisciculture Inventory System!
  Use the UP and Down arrow keys to navigate through the choices.
  Press ENTER to select an option.

*******   Menu  *******";
        string[] options = { "Daily Sales", "Weekly Sales", "Monthly Sales", "Return to Main Menu" };

        while (true)
        {
            Scroller starting = new Scroller(prompt, options);
            int index = starting.Navigate();
            switch (index)
            {
                case 0:
                    fishFarm.SalesReport("Daily");
                    break;
                case 1:
                    fishFarm.SalesReport("Weekly");
                    break;
                case 2:
                    fishFarm.SalesReport("Monthly");
                    break;
                case 3:
                    Fishfarmdetails Fm = new Fishfarmdetails();
                    Fm.Menu();
                    break;
            }
        }
    }
}
internal class Fishmanagementsystem
{
    public void Main()
    {
        var farm = new FishFarm();
        farm.LoadData();
        string prompt = @"
███████╗███████╗ █████╗     ██╗      █████╗     ██╗   ██╗██╗███████╗
██╔════╝██╔════╝██╔══██╗    ██║     ██╔══██╗    ██║   ██║██║██╔════╝
███████╗█████╗  ███████║    ██║     ███████║    ██║   ██║██║█████╗  
╚════██║██╔══╝  ██╔══██║    ██║     ██╔══██║    ╚██╗ ██╔╝██║██╔══╝  
███████║███████╗██║  ██║    ███████╗██║  ██║     ╚████╔╝ ██║███████╗
╚══════╝╚══════╝╚═╝  ╚═╝    ╚══════╝╚═╝  ╚═╝      ╚═══╝  ╚═╝╚══════╝
                             /`·.¸
                             /¸...¸`:·
                         ¸.·´  ¸   `·.¸.·´)
                        : © ):´;      ¸  {
                         `·.¸ `·  ¸.·´\`·¸)
                             `\\´´\¸.·´

             A Mini-Pisciculture Inventory System!
  Use the UP and Down arrow keys to navigate through the choices.
  Press ENTER to select an option.

*******   Menu  *******";
        string[] options = { "Add Fish", "Delete Fish", "Modify Fish", "Search Fish from Farm List", "Harvest Fish", "Update Price", "Sell Fish", "Return to Main Menu" };

        while (true)
        {
            Scroller starting = new Scroller(prompt, options);
            int index = starting.Navigate();      
            switch (index)
            { 
                case 0:
                    farm.DisplayAllFarmDetails();
                    try
                    {
                        farm.AddFishCage();
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("----------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in adding to fish farm. Press ENTER to return! |");
                        Console.WriteLine("----------------------------------------------------------------------");

                        Console.ReadKey(true);
                    }
                    break;
                case 1:
                    farm.DisplayAllFarmDetails();
                    try
                    {
                        farm.DeleteFishCage();
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in deleting fish farm. Press ENTER to return! |");
                        Console.WriteLine("---------------------------------------------------------------------");

                        Console.ReadKey(true);
                    }
                    break;
                case 2:
                    farm.DisplayAllFarmDetails();
                    try
                    {
                        farm.ModifyFishCage();
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("----------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in modifying fish farm. Press ENTER to return! |");
                        Console.WriteLine("----------------------------------------------------------------------");

                        Console.ReadKey(true);
                    } 
                    break;      
                case 3:
                    farm.DisplayAllFarmDetails();
                    try
                    {
                        farm.SearchFishCage();
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in searching fish in fish farm. Press ENTER to return! |");
                        Console.WriteLine("------------------------------------------------------------------------------");

                        Console.ReadKey(true);
                    }  
                    break;
                case 4:
                    farm.DisplayAllFarmDetails();
                    try
                    {
                        farm.HarvestFish();
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in harvesting fish in fish farm. Press ENTER to return! |");
                        Console.WriteLine("-------------------------------------------------------------------------------");

                        Console.ReadKey(true);
                    }
                    break;
                case 5:
                    try
                    {
                        farm.UpdateHarvestedFishPrice();
                    }
                    catch(FormatException)
                    {
                        Console.Clear();
                        Console.CursorVisible = false;
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        Console.WriteLine("| There was a problem in Updating Fish price in fish farm. Press ENTER to return! |");
                        Console.WriteLine("-----------------------------------------------------------------------------------");

                        Console.ReadKey(true);
                    }
                    break;
                case 6:
                    farm.SellFish();
                    break;
                case 7:
                    Fishfarmdetails Fm = new Fishfarmdetails();
                    Fm.Menu();
                    break;
            }
        }
    }
}
class FishCage
{
    public int CageNumber { get; set; }
    public string CageType { get; set; }
    public string FishType { get; set; }
    public double QuantityKg { get; set; }
   
    public FishCage(int cageNumber, string cageType, string fishType, double quantityKg)
    {
        CageNumber = cageNumber;
        CageType = cageType;
        FishType = fishType;
        QuantityKg = quantityKg;
      
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Cage Number: {CageNumber}, Type: {CageType}, Fish: {FishType}, Weight: {QuantityKg}kg");
    }
    
}
class HarvestedFish : FishCage
{
    public double PricePerKg { get; set; }
    public HarvestedFish(int cageNumber, string cageType, string fishType, double quantityKg, double pricePerKg)
        : base(cageNumber, cageType, fishType, quantityKg)
    {
        PricePerKg = pricePerKg;
    }
    public override void DisplayInfo()
    {    
        base.DisplayInfo();
        Console.WriteLine($"Price per Kg: {PricePerKg}");
    }
}
class FishFarm
{
    private List<FishCage> cages = new List<FishCage>();
    private List<HarvestedFish> harvestedFish = new List<HarvestedFish>();
    private const string FilePath = "fishfarm_data.txt";
    private const string SalesreportFilePath = "Salesreport.txt";
    private bool isFiltered = false;
    public void DisplayAllFarmDetails()
    {
        Console.Clear();
        Console.WriteLine("************************* Fish Farm Details ***************************");
        
        if (cages.Count > 0)
        {
            Console.WriteLine("Fish Cages:");
            foreach (var cage in cages)
                cage.DisplayInfo();
            Console.WriteLine("************************************************************************");
        }
        else
        {
            Console.WriteLine("No fish cages data available.");
        }
    }
    public void DisplayHarvestedFish()
    {
        Console.Clear();
        Console.WriteLine("**************************** Harvested Fish ****************************");
        if (harvestedFish.Count > 0)
        {
            foreach (var fish in harvestedFish)
                fish.DisplayInfo();
            Console.WriteLine("************************************************************************");
        }
        else
        {
            Console.WriteLine("No harvested fish data available.");
        }     
    }  
    public void AddFishCage()
    {
        Console.CursorVisible = true;
        int cageNumber;
        while (true)
        {
            Console.Write("\nEnter Cage Number (1-100): ");
            cageNumber = int.Parse(Console.ReadLine());

            if (cageNumber < 1 || cageNumber > 100)
            {
                Console.CursorVisible = false;
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("| Cage number must be between 1 and 100! Press ENTER to return. |");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.ReadKey(true);
                return;
            }
            if (cages.Any(f => f.CageNumber == cageNumber))
            {
                Console.CursorVisible = false;
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("| Cage number already exists! Please enter a new cage number. Press ENTER to return. |");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.ReadKey(true);
                return;
            }
            else
            {
                break;
            }
        }
        Console.Write("Enter Cage Type (Fixed Cage, Floating Cage, or Submerged Cage): ");
        string cageType = Console.ReadLine();
        Console.Write("Enter Fish Type: ");
        string fishType = Console.ReadLine();
        Console.Write("Enter Weight in Kg: ");
        double quantityKg = double.Parse(Console.ReadLine());

        cages.Add(new FishCage(cageNumber, cageType, fishType, quantityKg));
        DisplayAllFarmDetails();
        SaveData();
        Console.Write("\nFish cage added successfully. Press any key to return");

        Console.ReadKey(true);
    }
    public void ModifyFishCage()
    {
        Console.CursorVisible = true;
        Console.Write("\nEnter Cage Number to modify: ");
        int cageNumber = int.Parse(Console.ReadLine());
        if (cageNumber < 1 || cageNumber > 100)
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Cage number must be between 1 and 100! Press ENTER to return. |");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }
        var cage = cages.FirstOrDefault(c => c.CageNumber == cageNumber);
        if (cage != null)
        {
            Console.Write("Enter new Cage Type (Fixed Cage, Floating Cage, or Submerged Cage): ");
            cage.CageType = Console.ReadLine();
            Console.Write("Enter new Fish Type: ");
            cage.FishType = Console.ReadLine();
            Console.Write("Enter new Weight in Kg: ");
            cage.QuantityKg = double.Parse(Console.ReadLine());
            DisplayAllFarmDetails();
            Console.Write("\nFish cage modified successfully. Press any key to return");
            Console.ReadKey(true);
        }
        else
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Farm with specified Cage Number not found! Press ENTER to return. |");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }
        SaveData();       
    }
    public void DeleteFishCage()
    {
        Console.CursorVisible = true;
        Console.Write("\nEnter Cage Number to delete: ");
        int cageNumber = int.Parse(Console.ReadLine());

        if (cageNumber < 1 || cageNumber > 100)
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Cage number must be between 1 and 100! Press ENTER to return. |");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }

        var cage = cages.FirstOrDefault(c => c.CageNumber == cageNumber);
        if (cage != null)
        {
            cages.Remove(cage);
            DisplayAllFarmDetails();
            Console.Write("\nFish cage deleted successfully. Press any key to return");
            Console.ReadKey(true);
        }
        else
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Farm with specified Cage Number not found! Press ENTER to return. |");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }        
        SaveData();        
    }

    public void SearchFishCage()
    {
        Console.CursorVisible = true;
        Console.Write("\nEnter the kind of fish to search for: ");
        string fishType = Console.ReadLine().ToLower();

        var matchingCages = cages.Where(c => c.FishType.ToLower() == fishType).ToList();
        if (matchingCages.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("**************************** Search Results ****************************");
            foreach (var cage in matchingCages)
            {
                cage.DisplayInfo();
                Console.WriteLine("************************************************************************");
            }
            isFiltered = true;
            Console.Write("\nFish cage successfully searched. Press any key to return");
            Console.ReadKey(true);
        }
        else
        {
            Console.Write("\nNo cages found with that kind of fish.Press any key to return");
            Console.ReadKey(true);
        }
    }
    public void HarvestFish()
    {
       
        if (!cages.Any())
        {
            Console.CursorVisible = false;
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("| No fish are currently stored in the farm! Press ENTER to continue. |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }
        Console.CursorVisible = true;
        Console.Write("\nEnter Cage Number to harvest: ");
        int cageNumber = int.Parse(Console.ReadLine());
        if (cageNumber < 1 || cageNumber > 100)
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("| Cage number must be between 1 and 100! Press ENTER to return. |");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }

        var cage = cages.FirstOrDefault(c => c.CageNumber == cageNumber);
        if (cage != null)
        {
            Console.Write("Enter Price per Kg: ");
            double pricePerKg = double.Parse(Console.ReadLine());
            harvestedFish.Add(new HarvestedFish(cage.CageNumber, cage.CageType, cage.FishType, cage.QuantityKg, pricePerKg));
            cages.Remove(cage);
            DisplayHarvestedFish();
            Console.Write("\nFish harvested successfully. Press any key to return");
            Console.ReadKey(true);
        }
        else
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("| Fish cage does not exist! Press ENTER to continue. |");
            Console.WriteLine("------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }
        SaveData();       
    }

    public void UpdateHarvestedFishPrice()
    {
        Console.CursorVisible = true;
        DisplayHarvestedFish();
        Console.Write("\nEnter Cage Number of harvested fish to update price: ");
        int cageNumber = int.Parse(Console.ReadLine());

        var fish = harvestedFish.FirstOrDefault(f => f.CageNumber == cageNumber);
        if (fish != null)
        {
            Console.Write("Enter new Price per Kg: ");
            fish.PricePerKg = double.Parse(Console.ReadLine());
            DisplayHarvestedFish();
            Console.Write("\nHarvested fish price updated successfully. Press any key to return");
            Console.ReadKey(true);
        }
        else
        {
            Console.WriteLine();
            Console.CursorVisible = false;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("| No harvested fish found! Press ENTER to continue. |");
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey(true);
            return;
        }     
        SaveData();    
    }
    public void SellFish()
    {
        Console.Clear();
        if (!harvestedFish.Any())
        {
            Console.CursorVisible = false;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("| No fish have been harvested yet! Nothing to sell. Press ENTER to return. |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ReadKey(true);
            return;
        }
        Console.WriteLine("\n******************** Selling Fish ********************");
        double totalAmount = 0;
        Console.CursorVisible = true;
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string transactionId = Guid.NewGuid().ToString().Substring(0, 8); 

  
        List<string> soldFishDetails = new List<string>();
        using (StreamWriter reportWriter = new StreamWriter(SalesreportFilePath, append: true))
        {
            while (true)
            {
                Console.WriteLine("Please choose the type of fish you want to sell:");
                for (int i = 0; i < harvestedFish.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {harvestedFish[i].FishType} (Available: {harvestedFish[i].QuantityKg} kg)");
                }
                Console.Write("Enter the number of the fish type (0 to finish): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                if (choice < 1 || choice > harvestedFish.Count)
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }

                HarvestedFish selectedFish = harvestedFish[choice - 1];
                Console.Write($"Enter the quantity (kg) of {selectedFish.FishType} you want to sell: ");
                double quantityToSell = double.Parse(Console.ReadLine());

                if (quantityToSell <= 0 || quantityToSell > selectedFish.QuantityKg)
                {
                    Console.WriteLine("Invalid quantity, please enter a value between 1 and available quantity.");
                    continue;
                }

                double amount = quantityToSell * selectedFish.PricePerKg;
                totalAmount += amount;
                

                soldFishDetails.Add($"{selectedFish.FishType,-20} {quantityToSell,-15} Php {selectedFish.PricePerKg:N}   Php {amount:N}");
                selectedFish.QuantityKg -= quantityToSell;
                
                if (selectedFish.QuantityKg == 0)
                {
                    harvestedFish.Remove(selectedFish);
                }
            }
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("\n--- Receipt ---");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("                  Sea la Vie Fish Sale Receipt                  ");
            Console.WriteLine("                  Thank you for your purchase!                  ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"Transaction ID: {transactionId}");
            Console.WriteLine($"Date: {currentDate}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"{"Fish Type",-20} {"Quantity (kg)",-15} {"Price per kg",-15} {"Amount"}");
            Console.WriteLine("----------------------------------------------------------------");

            foreach (var detail in soldFishDetails)
            {
                Console.WriteLine(detail);
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"{"Total Sale Amount",-50}Php {totalAmount:N}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(    "Thank you for supporting Sea la Vie's Mini-Pisciculture!    ");
            Console.WriteLine("----------------------------------------------------------------");

      
            reportWriter.WriteLine($"Transaction ID: {transactionId}");
            reportWriter.WriteLine($"Date: {currentDate}");
            reportWriter.WriteLine($"Fish Sold:");
            foreach (var detail in soldFishDetails)
            {
                reportWriter.WriteLine(detail);
            }
            reportWriter.WriteLine($"Total Sale Amount: Php {totalAmount:N}");
            reportWriter.WriteLine("-----------------------------------------------------------------");
            reportWriter.WriteLine();
        }

        SaveData();

        Console.WriteLine("\nReceipt printed and saved successfully!");
        Console.WriteLine($"Total Sale Amount: Php {totalAmount:N}");
        Console.WriteLine("All fish successfully sold. Press any key to return.");
        Console.ReadKey(true);
    }

    private void SaveData()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            try
            {
                writer.WriteLine("********** Active Fish Cages **********");
                foreach (var cage in cages)
                {
                    writer.WriteLine($"{cage.CageNumber},{cage.CageType},{cage.FishType},{cage.QuantityKg}");
                }
                writer.WriteLine("********** Harvested Fish **********");
                foreach (var fish in harvestedFish)
                {

                    writer.WriteLine($"{fish.CageNumber},{fish.CageType},{fish.FishType},{fish.QuantityKg},{fish.PricePerKg}");
                }
            }
            catch (Exception ex)
            {
                Console.CursorVisible = false;
                Console.WriteLine($"Errorr: {ex.Message}");
                Console.ReadKey(true);
            }     
        }
    }
    public void SalesReport(string period)
    {
        Console.Clear();
        if (!File.Exists(SalesreportFilePath))
        {
            Console.WriteLine("No sales report found.");
            return;
        }

        DateTime startDate = period.ToLower() switch
        {
            "daily" => DateTime.Now.Date,
            "weekly" => DateTime.Now.AddDays(-7),
            "monthly" => DateTime.Now.AddDays(-30),
        };
        Console.WriteLine($"\n---------------- {period.ToUpper()} SALES REPORT -------------------");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"{"Date"}        {"Time"}                        {"Total Amount"}");
        Console.WriteLine("-------------------------------------------------------");

        double totalSales = 0;
        bool foundSales = false;
        try
        {
            using (StreamReader reader = new StreamReader(SalesreportFilePath))
            {
                string line;
                DateTime transactionDate = DateTime.MinValue;
                double transactionAmount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Date:"))
                    {
                        string dateString = line.Substring(5).Trim();
                        if (!DateTime.TryParse(dateString, out transactionDate))
                        { 
                            continue;
                        }
                    }
                    else if (line.StartsWith("Total Sale Amount:"))
                    {
                        string amountString = line.Substring(18).Trim().Replace("Php", "").Trim();
                        if (!double.TryParse(amountString, out transactionAmount))
                        {

                            continue;
                        }

                        if (transactionDate >= startDate)
                        {
                            Console.WriteLine($"{transactionDate:yyyy-MM-dd  HH:mm:ss}                    Php {transactionAmount:N2}");
                            totalSales += transactionAmount;
                            foundSales = true;
                        }
                    }
                }
            }

            if (foundSales)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"{"Total Sales for " + period}                   Php {totalSales:N2}");
                Console.WriteLine("-------------------------------------------------------");
            }
            else
            {
                Console.CursorVisible = false;
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("| No sales data found for the specified period! Press ENTER to return. |");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ReadKey(true);
                return;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("Press any key to return.");
        Console.ReadKey(true);
    }
    public void LoadData()
    {
        try
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                bool isHarvestedSection = false;

                while ((line = reader.ReadLine()) != null)
                {

                    if (line == "********** Active Fish Cages **********")
                    {
                        isHarvestedSection = false;
                        continue;
                    }
                    else if (line == "********** Harvested Fish **********")
                    {
                        isHarvestedSection = true;
                        continue;
                    }


                    var data = line.Split(',');

                    if (isHarvestedSection)
                    {
                        harvestedFish.Add(new HarvestedFish(
                            int.Parse(data[0]),
                            data[1],
                            data[2],
                            double.Parse(data[3]),
                            double.Parse(data[4])
                        ));
                    }
                    else
                    {
                        cages.Add(new FishCage(
                            int.Parse(data[0]),
                            data[1],
                            data[2],
                            double.Parse(data[3])
                        ));
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.CursorVisible = false;
            Console.WriteLine($"Error: {ex.Message}");
            Console.ReadKey(true);
        }
    }
}


