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




}
