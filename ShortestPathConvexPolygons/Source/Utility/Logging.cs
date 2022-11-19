using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class Logger
{
    private readonly string _name;
    private readonly string _path;
    private readonly FileInfo _file;
    private readonly FileStream _fstream;


    public string FileName => _name;
    public string Path => _path;

    public Logger()
    {
        string userName = Environment.UserName;

        _name = $"{DateTime.Now.ToFileTime()}_log";
        _path = $@"c:\Users\{userName}\Desktop\{_name}.csv";
        _file = new FileInfo(_path);

        if (!_file.Exists)
        {
            _fstream = File.Create(_name);
            _fstream.Close();
        }
    }

    public void AddToLog(List<string> itemsToAdd)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in itemsToAdd)
        {
            sb.Append(item + ",");
        }

        AppendString(sb.ToString());
    }

    private void AppendString(string line)
    {
        var sw = new StreamWriter(_path, true, Encoding.Default);
        sw.WriteLine(line);
        sw.Close();
    } 
}
