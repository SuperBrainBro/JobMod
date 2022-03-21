using Newtonsoft.Json;
using System.IO;
using Terraria.ModLoader;
using Terraria;

namespace JobMod
{
    public class JobMod : Mod
    {
        public override void Load()
        {
            Job job_lumberjack = new Job()
            {
                JobName = "Lumberjack",
                JobDescription = "Chop trees! Earn a passive income as well as increasing wood sell price.",
                JobWage = 75,
            };
            Job job_miner = new Job()
            {
                JobName = "Miner",
                JobDescription = "Mine! Earn a passive income as well as increasing mining speed.",
                JobWage = 75,
            };
            Job job_defender = new Job()
            {
                JobName = "Defender",
                JobDescription = "Defend! Earn a passive income as well as increase damage in villiage.",
                JobWage = 75,
            };
            Job job_haggler = new Job()
            {
                JobName = "Haggler",
                JobDescription = "Haggler! Decreases shop prices.",
                JobWage = 0,
            };
            string path = Path.Combine(Terraria.Main.SavePath, "JobList.json");

            string JSON_lumberjack = JsonConvert.SerializeObject(job_lumberjack);
            string JSON_miner = JsonConvert.SerializeObject(job_miner);
            string JSON_defender = JsonConvert.SerializeObject(job_defender);
            string JSON_haggler = JsonConvert.SerializeObject(job_haggler);


            StreamWriter sw = new StreamWriter(path, false);


            sw.WriteLine(JSON_lumberjack.ToString());
            sw.WriteLine(JSON_miner.ToString());
            sw.WriteLine(JSON_defender.ToString());
            sw.WriteLine(JSON_haggler.ToString());

            sw.Close();
        }
    }

    class Job
    {
        public string JobName;
        public string JobDescription;

        public double JobWage;
    }
}