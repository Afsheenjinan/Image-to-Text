
`
// string txt = "ABCDEFGHIJKLNOPQRSTUVMW@#$%&XYZabcdefghijklmnopqrstuvwxyz;/!^*~',._`-=+|:\"?><123456789";
string txt = "@B&NWMOGSXUKFJItTL+*;~:,\".`'@B&NWMOGSXUKFJItTL+*;~:,\".`'";
string word = txt + Environment.NewLine;
for (int i = 1; i < txt.Length; i++)
{
 word += txt.Substring(i) + txt.Substring(0, i) + Environment.NewLine;

}
File.WriteAllText("asdra.txt", word);
this.Close();
