﻿using System;
using System.IO;
using M11J1.AST;

namespace M11J1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("starting...");
            //Scanner scanner = new Scanner(
            //    new FileStream(args[0], FileMode.Open));
            //Parser parser = new Parser(scanner);
            //Console.WriteLine("parsing...");
            //parser.Parse();
            //Console.WriteLine("finished.");
            //Console.ReadLine();

             var pro = new CompilationUnit("test", new ClassDeclaration());

            /* Tarandeep Class Modifier*/
            var mod = new ClassModifier("public");   // testing class modifiers

            var method = new MethodDeclaration("public", new MethodHeader(), new MethodBody());

            pro.DumpValue(0);
            mod.DumpValue(0);
            method.DumpValue(0);
        }
    }
}
