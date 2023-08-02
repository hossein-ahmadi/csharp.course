// Demo64 - Interfaces
// TOSINSO C# Mega Course

using Demo64___Interfaces.Abstracts;
using Demo64___Interfaces.Concrets;

var car = new BmwCar();

car.Start();
((IEngine)car).Stop();

var audiSystem = car as IAudioSystem;

audiSystem.Stop();