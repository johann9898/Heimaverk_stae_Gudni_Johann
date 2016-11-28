## Synopsis

Grafísk reiknivél sem sýnir föll á bilinu -50 til 50 á x og y ás.

## Motivation

Hópverkefni í STÆ3FM03ETS, haust 2016

## Installation

Downloada Zip skrá
Builda með visual studio
Runna frá Heimaverk_stae_Gudni_Johann\bin\Debug\Heimaverk_stae_Gudni_Johann.exe

## Usage

Hægt er að setja inn hvernig fall sem er.
Hér eru dæmi um hvernig skrifa þarf föllin svo forritið skilji þau:

f(x) = 0
Getur tekið við föstum

f(x) = x
Getur notað breytilinn x

f(x) = 5 * x
x má margfalda með tölu, forritið getur ekki skilið þetta án margföldunarmerkis. (bara "5x" mundi bila).

f(x) = Pow(x, 2)
Notar fallið Pow() til þess að setja x í annað veldi. Notað svona: Pow(x, veldi)

f(x) = (Pow(x, 2) + 5) / Pow(x, 3)
Það er reiknað fyrst innan úr svigum.

## API Reference

NCalc - Mathematical Expressions Evaluator for .NET
https://ncalc.codeplex.com/

## License

MIT License

Copyright (c) 2016 Guðni Natan Gunnarsson & Jóhann Rúnarsson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
