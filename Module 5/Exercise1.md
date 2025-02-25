# Memory Leaks Exercise

Welcome to the Memory Leaks Exercise project! This project is designed to help you understand and identify various types of memory leaks in .NET applications. You will use the .NET Allocation Tool and Memory Usage Tool in Visual Studio Profilers to discover and analyze memory leaks.

## Project Structure

The project contains the following files and classes:

- `Program.cs`: Entry point of the application.
- `PotionEventHandler.cs`: Demonstrates event handler leaks.
- `PotionStorage.cs`: Demonstrates static reference leaks.
- `PotionMixer.cs`: Demonstrates closure in anonymous methods leaks.

## Prerequisites

- Visual Studio 2022 or later
- .NET 9.0 SDK

## Getting Started

1. **Clone the Repository**:
   
2. **Open the Project in Visual Studio**:
   - Launch Visual Studio.
   - Open the `Module 5.sln` solution file.

3. **Build the Project**:
   - Build the solution to ensure all dependencies are restored and the project compiles successfully.

## Using the .NET Allocation Tool

1. **Start a Diagnostic Session**:
   - Go to `Debug > Performance Profiler` or press `Alt + F2`.
   - Select `.NET Object Allocation Tracking` and click `Start`.

2. **Run the Application**:
   - Let the application run for a few minutes to capture allocation data.
   - Click `Stop collection` to end the diagnostic session.

3. **Analyze the Results**:
   - The Allocation Tool will display a summary of object allocations.
   - Look for objects with high allocation counts and large memory usage.
   - Identify the source of these allocations in the code.

## Using the Memory Usage Tool

1. **Start a Diagnostic Session**:
   - Go to `Debug > Performance Profiler` or press `Alt + F2`.
   - Select `Memory Usage` and click `Start`.

2. **Run the Application**:
   - Let the application run for a few minutes to capture memory usage data.
   - Click `Take snapshot` to capture the current memory state.
   	- Wait a few seconds and then click `Take snapshot` again.
   - Click `Stop collection` to end the diagnostic session.

3. **Analyze the Results**:
   - The Memory Usage Tool will display a summary of memory usage.
   - Compare snapshots to identify memory growth over time.
   - Look for objects that are not being released and investigate their references.

## Creating and Comparing GC Dumps

1. **Create the First GC Dump**:
   - Open a terminal and navigate to the project directory.
   - Run the application: `dotnet run`
   - To get <process-id>, run `dotnet ps` in the terminal.
   - In another terminal, create a GC dump: `dotnet-gcdump collect -p <process-id> -o first_dump.gcdump`
   
2. **Create the Second GC Dump**:
   - Let the application run for a few more minutes.
   - Create another GC dump: `dotnet-gcdump collect -p <process-id> -o second_dump.gcdump`

3. **Compare GC Dumps in Visual Studio**:
   - Open Visual Studio.
   - Go to `Debug > Performance Profiler` or press `Alt + F2`.
   - Select `Open > Memory Dump` and open `second_dump.gcdump`.
   - Go to Compare With Baseline and choose `first_dump.gcdump`.
   - Compare the two dumps to identify differences in memory usage.

## Taking a Dump and Running Diagnostic Analysis

1. **Take a Dump Using dotnet-dump**:
   - Open a terminal and navigate to the project directory.
   - Run the application: `dotnet run`
   - In another terminal, take a dump: `dotnet-dump collect -p <process-id> -o memory_dump.dmp`

2. **Run Diagnostic Analysis on the Dump**:
   - Open Visual Studio.
   - Go to `Debug > Performance Profiler` or press `Alt + F2`.
   - Select `Open > Memory Dump` and open `memory_dump.dmp`.
   - Click `Run Diagnostic Analysis` to analyze the dump.

## Make sure you found the following leaks, you may fix them and run the tools again

1. **Event Handler Leak**:
   - Analyze `PotionEventHandler.cs` to identify the event handler leak.

2. **Static Reference Leak**:
   - Analyze `PotionStorage.cs` to identify the static reference leak.

3. **Closure in Anonymous Methods Leak**:
   - Analyze `PotionMixer.cs` to identify the closure in anonymous methods leak.



