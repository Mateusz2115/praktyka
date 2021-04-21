
class Dokument
{
    protected String issuer;  //wystawca
    protected String receiver;
    protected DateTime date;
    protected int number;

    public Dokument(String issuer, String receiver, DateTime date, int number)
    {
        this.issuer = issuer;
        this.receiver = receiver;
        this.date = date;
        this.number = number;
    }

    public void getRabat()
    {
        Console.WriteLine("no discount");
    }
    
    String getIssuer() { return issuer; }

    String geReceiver() { return receiver; }

    DateTime getDate() { return date; }

    int getNumber() { return number; }

}

class Zamowienie : Dokument
{
    DateTime realizationDate;

    Zamowienie(String issuer, String receiver, DateTime date, int number, DateTime realizationDate) : base(issuer, receiver, date, number)
    {
        this.realizationDate = realizationDate;
    }

    public String getRabat()
    {
        return "Rabat from " + receiver;
    }

}

class Faktura : Dokument
{
    String fakturaType;

    Faktura(String issuer, String receiver, DateTime date, int number, String fakturaType) : base(issuer, receiver, date, number)
    {
        this.fakturaType = fakturaType;
    }

    public String getRabat()
    {
        return "Rabat from " + fakturaType + " number: " + number.ToString();
    }
}
