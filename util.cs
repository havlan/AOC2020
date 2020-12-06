using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System;


public static class Util<T> {
    public static async Task<IList<T>> GetDataAsList(string filename, Func<string, T> converter){
        var data = new List<T>();
        using(var fs = new FileStream(filename, FileMode.Open)){
            using (var reader = new StreamReader(fs)){
                string line;
                while((line = await reader.ReadLineAsync()) != null){
                    data.Add(converter(line));
                }
            }
        }
        return data;
    }
}