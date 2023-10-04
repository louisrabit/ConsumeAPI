using (HttpClient client = new HttpClient())
{
    try
    {
 string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
   
}



//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");
//        Console.WriteLine(resposta);
//    }


//    catch (Exception ex)
//    {
//        Console.WriteLine($"Temos um problema: {ex.Message}");
//    }
//}
