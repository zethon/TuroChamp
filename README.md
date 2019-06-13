# TuroChamp

(c) 2019 Adalid Claure

Released under the BSD license, see 'license.txt' for details.

## Introduction 

This is a C# implementation of the _Turochamp_ chess engine. This project aims to be compatible with [The Chess Engine Communication Protocol](http://home.hccnet.nl/h.g.muller/engine-intf.html) and therefore useable with GUI implemenations such as Xboard/WinBoard.

## What is Turochamp?

_Turochamp_ is considered the first chess engine. It was never fully implemented as computers at the time of its conception did not have the processing power necessary to run the engine. The engine was developed by Alan Turing and David Champernowne.

The engine works by calculating every potential move and assigning a point value to each possible state of the board, and then executing the move with the greatest points. The engine is capable of solving certain puzzles, such as _Mate in Two_.

## Point Value System

*TBD*<br/>

At the time of this writing the exact point value system has not been designed and there seems to be no definitive source of the engine's original point value system. 
