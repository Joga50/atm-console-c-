using System;

public class cardHolder
{
    String firstName;
    String lastName;
    int pin;
    String cardNum;
    double balance;

public cardHolder(string firstName, string lastName, int pin, string cardNum, double balance) 
      
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.pin = pin;
        this.cardNum = cardNum;
        this.balance = balance;
   }

    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName() {
        return lastName;        
    }
    
    public int getPin()
    {
            return pin;
    }

    public String getCardNum() {
        return cardNum;    
    }

    public double getBalance()
    {
        return balance;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public  void    setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    { lastName = newLastName; }
     
    public void setBalance(double newBalance)
    { balance = newBalance; }


    public static void Main(String[] args)

    {
        void printOptions()
        {
            Console.WriteLine("Please choose from on of the options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money do you want to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance()+ deposit);
            Console.WriteLine("Ty your new balance is: " + currentUser.getBalance() );
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money do oyu want to withdreaw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //YOU HAVE to check that the user doesnt withdraw more money than he has"
            if(currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("INSUFFICIENT BALANCE");
            }
            else 
            { 
                
 
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you, you can go");
            }

        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("|| YourCurrent balance is: " + currentUser.getBalance() + " ||");
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("Jose", "Alvarez",  1234, "123456789", 250.00));
        cardHolders.Add(new cardHolder("Gabriel", "Molina", 4321, "9876543219", 350.00));
        cardHolders.Add(new cardHolder("Juan", "Mejia", 3333, "123412341", 150.00));
        cardHolders.Add(new cardHolder("Pedro", "Nunez", 1234, "343434343", 650.00));
        cardHolders.Add(new cardHolder("Pablo", "Casas", 1234, "234567432", 550.00));



        // Creating Users Prompts

        Console.WriteLine("Welcome to your ATM");
        Console.WriteLine("Please insert card");
        String debitCardNum = "";
        cardHolder currentUser;


        //Validation for db users
        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized, try again"); }
            }

            catch { Console.WriteLine("Card not recognized, try again"); }
        }

        Console.WriteLine("Please enter your pin");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
               
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin, try again"); }
            }

            catch { Console.WriteLine("Incorrect pin, try again"); }
        }


        Console.WriteLine("Welcome " + currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if(option == 1) {
                deposit(currentUser
                );
            }
            else if (option == 2) {  withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }


        while (option != 4);
        Console.WriteLine("Thank you!");
    }
    }



