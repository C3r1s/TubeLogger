using System.Text;
using Tube;

Pipe tube = new Pipe();

StreamWriter file = new StreamWriter("E:\\Programming\\C# Proj\\Tube\\Tube.App\\Log\\Log.txt", false, Encoding.UTF8);
tube.Diameter = Cli.InputInt("Введите диаметр: ");
tube.Length = Cli.InputInt("Введите длину: ");
tube.Thickness = Cli.InputInt("Введите толщину: ");
tube.Manufacturer = Cli.InputString("Введите производителя: ");

string diameterCheckResult = CheckPass.IntCheck(tube.Diameter);
string lengthCheckResult = CheckPass.IntCheck(tube.Length);
string thicknessCheckResult = CheckPass.IntCheck(tube.Thickness);
string manufacturerCheckResult = CheckPass.StringCheck(tube.Manufacturer);
file.WriteLine($"Tube.App diameter - {tube.Diameter} \n Tube.App length - {tube.Length} \n Tube.App thickness - {tube.Thickness} \n Tube.App manufacturer - {tube.Manufacturer}\n");
file.WriteLine($"Diameter check - {diameterCheckResult}");
file.WriteLine($"Length check - {lengthCheckResult}");
file.WriteLine($"Thickness check - {thicknessCheckResult}");
file.WriteLine($"Manufacturer check - {manufacturerCheckResult}\n");
file.Close();