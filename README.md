# RPGgameCS

A small turn based RPG in C# and WPF. Walk around a map, fight monsters, do a quest, buy and sell with traders.

I built this following Scott Lilly's [Build a C#/WPF RPG](https://github.com/scottlilly/soscsrpg) lessons (MIT) when I was learning C# in 2023.

Rebuilt in Nov 2026 from Scott Lilly's SOSCSRPG series after losing my original from a work laptop. Commit dates are roughly when I first did each lesson.

## Run

Needs Windows and the .NET 6 SDK or newer.

```
dotnet run --project WPFUI
```

## Layout

- `Engine` models, factories and the `GameSession` view model
- `WPFUI` the main window and the trade screen

## Todo

- [ ] unit tests for `GameSession`
- [ ] move game data out of the factories
