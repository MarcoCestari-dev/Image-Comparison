using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageComparison.Functions
{
    class interconnectorPy
    {
        public static string getResultsComparison()
        {
            // 1) Crea un nuovo processo (Command Promp)
            var psi = new ProcessStartInfo();
            psi.FileName = "python"; // Nome del programma da usare per lanciare gli argomenti

            // 2) Provide script and arguments

            var script = Application.StartupPath + @"\algorithms\" + Properties.Settings.Default.pref_algorithm + ".py"; // Nome del file Python da eseguire
            var arg1 = Properties.Settings.Default.default_input_image; // Argomento 1
            var arg2 = Properties.Settings.Default.default_dir; // Argomento 2
            var arg3 = Application.StartupPath; // Argomento 3
            psi.Arguments = $"\"{script}\" \"{arg1}\" \"{arg2}\" \"{arg3}\""; // Fusione dello script con gli argomenti

            // Esempio Psi.Argument -> "python filePython.py "C://Argomento1" "C://Argomento2" "C://Argomento3"

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true; // Permette di NON vedere una shell aprirsi ogni volta che si lancia
            psi.RedirectStandardOutput = true; // Reindirizza l'OUTPUT per poter essere letto
            psi.RedirectStandardError = true; // Reindirizza gli ERRORI per poter essere letti

            // 4) Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi)) // Lancio effettivo del comando
            {
                errors = process.StandardError.ReadToEnd(); // Lettura di eventuali Errori per DEBUG
                results = process.StandardOutput.ReadToEnd(); // Lettura dell'Output
            }

            return results;
        }

        public static string runPyFile(string path, string arg_1, string arg_2, string arg_3)
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = "python";

            // 2) Provide script and arguments

            var script = Application.StartupPath + @"\algorithms\" + path + ".py";
            var arg1 = arg_1;
            var arg2 = arg_2;
            var arg3 = arg_3;
            psi.Arguments = $"\"{script}\" \"{arg1}\" \"{arg2}\" \"{arg3}\"";

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            return results;
        }
    }
}
