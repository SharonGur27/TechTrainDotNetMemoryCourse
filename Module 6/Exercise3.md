# Using PerfView to Find Memory Issues in Deployment

## Step 1: Download and Install PerfView
1. Go to the [PerfView GitHub Releases page](https://github.com/microsoft/perfview/releases).
2. Download the latest version of PerfView.
3. Extract the downloaded zip file to a preferred location on your machine.

## Step 2: Build the Project
1. Open Visual Studio 2022.
2. Load the `Module6` solution.
3. Make sure 'Deployment' is set as start up project.
4. Build the project by selecting __Build > Build Solution__ or pressing `Ctrl+Shift+B`.

## Step 3: Create a .nettrace File Using dotnet-trace
1. Open a command prompt or terminal.
2. Run the following command to start collecting trace data: dotnet-trace collect -p <process-id> --providers Microsoft-DotNETCore-SampleProfiler --format nettrace
   Replace `<process-id>` with the process ID of your running application. You can find the process ID using tools like Task Manager or `dotnet-trace ps`.
3. Run your application to reproduce the memory issues.
4. Press `Ctrl+C` in the command prompt or terminal to stop the trace collection. This will generate a `.nettrace` file in the current directory.

## Step 4: Open and Explore the .nettrace File in PerfView
1. Open PerfView by running `PerfView.exe`.
2. In PerfView, go to the __File__ menu and select __Open__.
3. Browse to the directory where the `.nettrace` file was generated and open it.
4. Navigate to the __Memory Group__ section in the left pane.
5. Select __GC Stats__ to view GC Statistics.

## Step 5: Run the Application with PerfView Collect
1. Open PerfView by running `PerfView.exe`.
2. In PerfView, go to the __Collect__ menu and select __Collect__.
3. In the __Advanced Options__ drop down, set the following options:
   - Check the `.NET Alloc` checkbox.
4. Click the __Start Collection__ button.
5. Wait a few minutes and Press __Stop Collection__

## Step 6: Analyze the Collected Data from PerfView Collect
1. After running your application, PerfView will collect the memory usage data and generate a `.etl.zip` file.
2. In PerfView, open the generated `.etl.zip` file.
3. Navigate to the __Memory Group__ section in the left pane.
4. Select __GC Stats__ to view GC Statistics.

## Step 7: Attempt to Run PerfView to Collect without GUI
1. Open PowerShell.
2. type <Path to PerfView/>PerfView.exe /GCCollectOnly /AcceptEULA /nogui collect
3. Run your application to reproduce the memory issues.
4. Wait a few minutes and press 'S' to stop the collection.
5. Open result in PerfView

## Step 8: Identify Memory Issues
1. Look for large objects or a high number of allocations that might indicate memory leaks or inefficient memory usage.
2. Pay attention to objects that are not being garbage collected, which might indicate references that are not being released properly.

## This Project Contains the following Memory Leak Types

1. **Event Handler Leak**: Subscribing to events without unsubscribing.
2. **Static Field Leak**: Storing objects in static fields.
3. **Timer Leak**: Using timers without stopping them.
4. **Unmanaged Resource Leak**: Allocating unmanaged memory without freeing it.
