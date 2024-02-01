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
