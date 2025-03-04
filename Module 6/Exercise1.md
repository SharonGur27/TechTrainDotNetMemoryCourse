# Using dotMemory to Find Memory Issues in WilliWonkaChocolateFactory

## Step 1: Download and Install dotMemory
1. Go to the Extensions -> Manage Extensions... and search for Resharper.
2. Mark dotMemory.
3. Run the installer and follow the on-screen instructions to complete the installation.

## Step 2: Build the Project
1. Open Visual Studio 2022.
2. Load the `WilliWonkaChocolateFactory` solution.
3. Build the project by selecting __Build > Build Solution__ or pressing `Ctrl+Shift+B`.

## Step 3: Run the Application with dotMemory Profiling
1. Open Visual Studio 2022.
2. Go to __Extensions__ -> __ReSharper__ -> __Profile__ -> __Run Startup Project Memory Profiling__.
3. Run your application to reproduce the memory issues.
4. Click __Get Snapshot__ in the dotMemory window to capture a memory snapshot.
5. Wait for a while, and take another one.

## Step 4: Open and Explore the Memory Snapshot in dotMemory
1. Compare the 2 Snapshots.
2. Attempt to play with the tool to see what you can get from it. Make sure you see Retention Graphs.

## Step 5: Identify Memory Issues
1. Look for large objects or a high number of allocations that might indicate memory leaks or inefficient memory usage.
2. Pay attention to objects that are not being garbage collected, which might indicate references that are not being released properly.
3. Use the __Comparative Analysis__ feature in dotMemory to compare memory usage between different snapshots to identify changes in memory behavior.

## Step 6: Optimize and Fix Memory Issues
1. Based on the findings from dotMemory, identify the parts of your code that are causing memory issues.
2. Refactor your code to optimize memory usage, such as:
   - Reducing the size of large objects.
   - Ensuring proper disposal of objects.
   - Avoiding unnecessary allocations.
3. Re-run dotMemory to verify that the memory issues have been resolved.

## This Project Contains the following Memory Leak Types

1. **Event Handler Leak**: Subscribing to events without unsubscribing.
2. **Static Field Leak**: Storing objects in static fields.
3. **Timer Leak**: Using timers without stopping them.
4. **Unmanaged Resource Leak**: Allocating unmanaged memory without freeing it.

