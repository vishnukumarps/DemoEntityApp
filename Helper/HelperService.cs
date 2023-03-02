namespace DemoEntityApp.Helper;

public class HelperClass
{

    public int  getOtp()
    {
        Random random = new Random();

        return random.Next(1000,9000);
    }

    public void SendEmail(string email, string otp)
    {

    }
}

