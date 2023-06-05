using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

private static void Serialize(Color[,] arr)
{ 
    new BinaryFormatter().Serialize(File.Open("colors.bin", FileMode.Create), arr);
}

private static Color[,] Deserialize()
{
    return (Color[,])new BinaryFormatter().Deserialize(File.Open("colors.bin", FileMode.Open));
}
