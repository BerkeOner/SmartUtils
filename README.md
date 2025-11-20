# SmartUtils

Contains Unity functions that are designed entirely to save you time.

## Overview

SmartUtils is a lightweight Unity utility library that simplifies and accelerates common tasks, helping you write cleaner and more efficient code. It currently includes:

* **TransformExtensions**: Easily manipulate individual axes of a Transform (Position, LocalPosition, Rotation, LocalRotation, Scale) using intuitive `.x`, `.y`, `.z` properties and full Quaternion access for rotations.
* **SDebug**: Smart debug logging that is automatically excluded from builds, keeping your game clean and optimized while still allowing logs in the editor.
* More helper utilities will be added over time.

## TransformExtensions

Easily modify Transforms with concise syntax:

**Old way:**

```csharp
Vector3 pos = transform.position;
pos.y = 0f;
transform.position = pos;
```

**New way with SmartUtils:**

```csharp
transform.Position().y = 0f;
```

Works for Position, LocalPosition, Rotation, LocalRotation and LocalScale. LossyScale is not included since its read only.

## SDebug

* Logs are automatically removed from builds, improving performance.
* Supports `Log`, `LogWarning`, and `LogError`.

```csharp
SDebug.Log("This will only appear in the editor");
SDebug.LogWarning("Warning only in editor");
SDebug.LogError("Error only in editor");
```

## Why Use SmartUtils?

* Saves time by simplifying common Transform manipulations.
* Keeps builds clean and optimized by excluding unnecessary logs.
* Provides a more readable and maintainable codebase.

## License

This project is open-source and free to use under the MIT License.
