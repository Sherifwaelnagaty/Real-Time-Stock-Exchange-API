<h1 align="center">Hi 👋, I'm Sherif Nagaty</h1>
<h3 align="center">A passionate Full-Stack developer from Egypt</h3>

- 🔭 I’m currently working on [Hospital System API](https://github.com/Sherifwaelnagaty)

- 👨‍💻 All of my projects are available at [https://github.com/Sherifwaelnagaty](https://github.com/Sherifwaelnagaty)

- 📫 How to reach me **Sherifwael0@gmail.com**

- 📄 Know about my experiences [https://drive.google.com/file/d/1Sn6s1sTU9nVWiE5Dt8LYnIwjGupDsUTM/view?usp=sharing](https://drive.google.com/file/d/1Sn6s1sTU9nVWiE5Dt8LYnIwjGupDsUTM/view?usp=sharing)

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://twitter.com/sherifnagaty3" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/twitter.svg" alt="sherifnagaty3" height="30" width="40" /></a>
<a href="https://linkedin.com/in/sherif-wael" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="sherif-wael" height="30" width="40" /></a>
</p>

<h3 align="left">Languages and Tools:</h3>
<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> <a href="https://git-scm.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/git-scm/git-scm-icon.svg" alt="git" width="40" height="40"/> </a> <a href="https://www.microsoft.com/en-us/sql-server" target="_blank" rel="noreferrer"> <img src="https://www.svgrepo.com/show/303229/microsoft-sql-server-logo.svg" alt="mssql" width="40" height="40"/> </a> <a href="https://postman.com" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/getpostman/getpostman-icon.svg" alt="postman" width="40" height="40"/> </a> </p>

## API Endpoints

### 1. Stock Data Endpoint

- **Endpoint:** `/api/stocks`
- **Method:** GET
- **Description:** Retrieve real-time stock data, including symbols, current prices, and timestamps.

### 2. Stock History Endpoint

- **Endpoint:** `/api/stocks/{symbol}/history`
- **Method:** GET
- **Description:** Retrieve historical stock data for a given stock symbol.

### 3. Order Creation Endpoint

- **Endpoint:** `/api/orders`
- **Method:** POST
- **Description:** Create orders with information such as stock symbol, order type (buy/sell), and quantity.

### 4. Orders History Endpoint

- **Endpoint:** `/api/orders`
- **Method:** GET
- **Description:** Retrieve orders history.

### Real-Time Updates

- **SignalR Hub:** `/stockUpdatesHub`
- **Description:** Real-time updates for stock prices are broadcasted through this hub.

## Authentication

The API is secured with basic authentication. Ensure that your requests include valid API key or token-based authentication.
