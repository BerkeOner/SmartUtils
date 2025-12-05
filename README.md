# SmartUtils

Contains Unity functions that are designed entirely to save you time. it simplifies and accelerates common tasks, helping you write cleaner and more efficient code. More helper utilities will be added over time.

## TransformExtensions

Easily manipulate individual axes of a Transform (Position, LocalPosition, Rotation, LocalRotation, Scale) using intuitive `.x`, `.y`, `.z` properties and full eulerAngles access for rotations. Easily modify Transforms with concise syntax:

**Old way:**

```csharp
Vector3 pos = transform.position;
pos.y = 0f;
transform.position = pos;
```

**New way with SmartUtils:**

```csharp
transform.Position().y = 0f; // You can use other operators as well such as +=, /=, etc.
```

Works for Position, LocalPosition, Rotation, LocalRotation and LocalScale.

## SDebug

Smart debug logging that is automatically excluded from builds, keeping your game clean and optimized while still allowing logs in the editor. Supports `Log`, `LogWarning`, and `LogError`.

```csharp
SDebug.Log("This will only appear in the editor");
SDebug.LogWarning("Warning only in editor");
SDebug.LogError("Error only in editor");
```

# DelayIt

It is a lightweight utility library for Unity that provides simple coroutine based methods to delay execution or wait for conditions before performing an action. I designed it completely to simplify the code part of our projects.

## Features

- Delay execution by a specific number of frames or seconds.
- Wait until a condition is met before executing an action.
- Combine time/frame delays with condition checks for quicker code flow.

## Usage

```csharp
StartCoroutine(DelayIt.LateStart(seconds: 2f, () => DoSomething())); // Delay by seconds
StartCoroutine(DelayIt.LateStart(frames: 60, () => DoSomething())); // Delay by frames
StartCoroutine(DelayIt.LateStartWithCondition(readyToStart, seconds: 2f, () => Init())); // Wait for a condition first, then frames
StartCoroutine(DelayIt.LateStartWithCondition(frames: 60, readyToStart, () => Init())); // Wait for frames and then condition
```

# Extra (not included)

This great lerping functions would fit well with these utils as well: https://github.com/brihernandez/SmoothDampingExample/blob/master/Assets/SmoothdampExample/Scripts/SmoothDamp.cs

## License

This project is open-source and free to use under the MIT License.
