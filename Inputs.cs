using Newtonsoft.Json;

namespace Beskrivande_statistik
{
    public static class Inputs
    {
        private static void CheckInputs(int[] source)  //En metod som kastar undantag om datakällan har nullvärde eller är tom
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Contains no elements");
            }
        }
        public static int[] ImportJSON() //En metod som importerar och datan från json-filen och spar den i en array som vi jobbar med i programmet
        {
            //Json filen måste ligga i användare och den måste heta data.json
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/data.json");
            string jsonString = File.ReadAllText(filePath);
            int[] import = JsonConvert.DeserializeObject<int[]>(jsonString);
            CheckInputs(import);
            return import;
        }
    }
}
