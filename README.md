# Magic Land Exploration Console App
Welcome to the Magic Land Exploration Console Application! This application allows users to interactively explore various destinations within the Magic Land theme park. Users can view information about different rides, shows, and dining options, filtered and manipulated using LINQ queries and delegates.

## Features
- **Interactive Console Interface**: Explore Magic Land through an interactive console interface.
- **Filter Destinations**: View destinations with a duration less than 100 minutes.
- **Find Longest Duration**: Identify the destination with the longest duration.
- **Sort Destinations**: Sort destinations alphabetically by name.
- **Top 3 Longest Destinations**: Display the top three longest-duration destinations.
- **Shared Location**: List all categories that have "Fantasyland" as a shared location.

## Installation

### Prerequisites

- .NET SDK installed on your machine. You can download it from the [official .NET website](https://dotnet.microsoft.com/download).

### Steps

1. **Clone the Repository**

    Open your terminal or command prompt and run the following commands:

    ```shell
    git clone https://github.com/yourusername/magic-land-exploration.git
    cd magic-land-exploration
    ```

2. **Install Dependencies**

    Install the `Newtonsoft.Json` package using NuGet Package Manager Console:

    ```shell
    Install-Package Newtonsoft.Json
    ```

    Or using the .NET CLI:

    ```shell
    dotnet add package Newtonsoft.Json
    ```

3. **Add JSON Data**

    Add the `data.json` file to the `data` folder within the project directory. Ensure the file is named `MagicLandData.json` and is properly formatted to match the expected structure.

## Usage

To run the project, use the following command in your terminal:

```shell
dotnet run
```

#### Interactive Console Menu
The application provides the following options:
1. **Show filtered destinations (duration < 100 minutes)**

2. **Show destination with the longest duration**

3. **Sort destinations by name**

4. **Show top 3 longest-duration destinations**

5. **List categories with "Fantasyland" as a shared location**

6. **Exit**


### Example Usage
```
Choose an option:
1- Show filtered destinations (duration < 100 minutes)
2- Show destination with the longest duration
3- Sort destinations by name
4- Show top 3 longest-duration destinations
5- List categories with "Fantasyland" as a shared location
6- Exit
```






