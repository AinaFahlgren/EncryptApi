var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Please write your name:");

app.MapGet("/encrypt", (string myName, int shift) => EncryptCaesar(myName, shift));

app.MapGet("/decrypt", (string myName, int shift) => DecryptCaesar(myName, shift));

app.Run();

string EncryptCaesar(string myName, int shift)
{
    char[] encryptedName = new char[myName.Length];

    for (int i = 0; i < myName.Length; i++)
    {
        char originalName = myName[i];

        if (char.IsLetter(originalName))
        {
            char shiftChar = (char)(originalName + shift);
            
            if ((char.IsUpper(originalName) && shiftChar > 'Z') || (char.IsLower(originalName) && shiftChar > 'z'))
            {
                shiftChar = (char)(shiftChar - 26);
            }
            encryptedName[i] = shiftChar;
            }
            else
            {
                encryptedName[i] = originalName;
            }
        }

        return new string(encryptedName);
    }


string DecryptCaesar(string myName, int shift)
{
    return EncryptCaesar(myName, -shift);
}