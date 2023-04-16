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
            currentUser.setBalance(deposit);
            Console.WriteLine("Ty your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money do oyu want to withdreaw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //YOU HAVE to check that the user doesnt withdraw more money than he has"
            if(currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("INSUFFICIENT BALANCE");
            }
            else 
            { 
                
 
                currentUser.setBalance(currentUser.getBalance()- withdrawal);
                Console.WriteLine("Thank you, you can go");
            }

        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance" + currentUser.getBalance());
        }



        }
    }



