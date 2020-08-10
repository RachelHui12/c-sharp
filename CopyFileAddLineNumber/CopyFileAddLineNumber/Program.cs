﻿using System;

using System.IO;

public class CopyFileAddLineNumber

{

    public static void Main(string[] args)

    {

        string infname = "Program.cs";

        string outfname = "CopyFileAddLineNumber.txt";

        if (args.Length >= 1) infname = args[0];
        if (args.Length >= 2) outfname = args[1];
        try
        {

            FileStream fin = new FileStream(
                infname, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(
                outfname, FileMode.Create, FileAccess.Write);
            StreamReader brin = new StreamReader(
                fin, System.Text.Encoding.Default);
            StreamWriter brout = new StreamWriter(
                fout, System.Text.Encoding.Default);



            int cnt = 0; // 行号

            string s = brin.ReadLine();

            while (s != null)

            {

                cnt++;

                s = deleteComments(s);                        //去掉以//开始的注释

                brout.WriteLine(cnt + ": \t" + s);           //写出

                Console.WriteLine(cnt + ": \t" + s);     //在控制上显示

                s = brin.ReadLine();                      //读入

            }

            brin.Close();               // 关闭缓冲读入流及文件读入流的连接.

            brout.Close();

        }

        catch (FileNotFoundException)

        {

            Console.WriteLine("File not found!");

        }

        catch (IOException e2)

        {

            Console.WriteLine(e2);

        }

    }



    static string deleteComments(string s) //去掉以//开始的注释

    {

        if (s == null) return s;

        int pos = s.IndexOf("//");

        if (pos < 0) return s;

        return s.Substring(0, pos);

    }

}

