﻿using System.Collections;

Menu();

static void Menu()
{
  Console.Clear();

  Console.WriteLine("Escolha  o modo que quer cronometrar");
  Console.WriteLine("1 => Cronometro progressivo");
  Console.WriteLine("2 => Cronometro regressivo");

  int stopwatchType = int.Parse(Console.ReadLine());
  Console.WriteLine(stopwatchType);
  Console.Clear();

  Console.WriteLine("S = Segundos => 10s = 10 segundos");
  Console.WriteLine("M = Minutos => 1m = 1 minuto");
  Console.WriteLine("0 = Sair");
  Console.WriteLine("Quanto tempo deseja contar?");


  string data = Console.ReadLine().ToLower();

  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  int multiplier = 1;

  if (type == 'm')
  {
    multiplier = 60;
  }

  if (time == '0')
  {
    System.Environment.Exit(0);
  }

  switch (stopwatchType)
  {
    case 1:
      PreStartProgressive(time * multiplier);
      break;
    case 2:
      PreStartRegressive(time * multiplier);
      break;
  }
}

static void PreStartProgressive(int time)

{
  Console.Clear();
  Console.WriteLine("Ready...");
  Thread.Sleep(500);
  Console.WriteLine("Set...");
  Thread.Sleep(500);
  Console.WriteLine("Go...");
  Thread.Sleep(500);
  StartProgressive(time);
}

static void StartProgressive(int time)
{
  int currentTime = 0;

  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(100);
  }

  Console.Clear();
  Console.WriteLine("Stopwatch finalizado");
  Thread.Sleep(1500);

  Menu();
}

static void PreStartRegressive(int time)
{
  Console.Clear();
  Console.WriteLine("Go...");
  Thread.Sleep(500);
  Console.WriteLine("Set...");
  Thread.Sleep(500);
  Console.WriteLine("Ready...");
  Thread.Sleep(500);
  StartRegressive(time);
}

static void StartRegressive(int time)
{
  int currentTime = 0;

  while (currentTime < time)
  {
    Console.Clear();
    Console.WriteLine(time);
    time--;
    Thread.Sleep(100);
  }

  Console.Clear();
  Console.WriteLine("Stopwatch finalizado");
  Thread.Sleep(1500);

  Menu();
}