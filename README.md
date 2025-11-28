# CatchCo Inventory Risk Monitor
## Azure Functions (.NET 8) + Blazor WebAssembly as UI framework (Blazor run over ASP.net) + Shopify API


### NOTE
I used AI to generate this decicion and readme.md based in all my documented code, 
commetns and that helps create it faster if you document code properly

### 📌 Overview
The **CatchCo Inventory Risk Monitor** is a full-stack solution that:
- Pulls product and order data from a Shopify development store
- Computes stockout risk per SKU
- Generates Slack-style alerts (simulated)
- Provides logic trace + downloadable artifacts
- Deploys on Azure Functions + Azure Static Web Apps

### 📦 Architecture
Azure Functions (.NET 8 Isolated)
├── /api/ListProducts
├── /api/ShopifyInventoryStatus
├── /api/ShopifyUnfulfilledOrders
├── /api/SendSlackAlert (simulated)
├── /api/DownloadSlackMessage
└── TimerDailyInventoryScan

Blazor WebAssembly Frontend
├── Home (inventory summary)
├── Slack (Slack preview + JSON)
└── Logs (trace + downloads)

### ⚙️ Backend Logic
Products: GET products.json?limit=250
Filtered: active + merchandise
Orders: GET orders.json?fulfillment_status=unfulfilled

Risk:
available = sum(inventory_quantity)
committed = unfulfilled quantities
on_hand = available + committed
stock_risk = available - committed

Alert if <= threshold (default 10)

### 🧪 Simulation Layer
Randomly injects 2–3 low-stock items for demo stability.

### 📤 Slack Simulation
POST /api/SendSlackAlert
Returns SLACK_SIMULATED_OK
Generates downloadable slack_out.txt and logic_trace.txt.

### 🕒 Daily Cron Job
Runs inventory check daily via TimerTrigger.

### 🖥 Frontend
Home → Summary + sync
Slack → Preview + JSON payload
Logs → Trace + downloads
Info → My explanation of all work done

### 🔐 Security
Secrets in environment variables:
SHOPIFY_STORE
SHOPIFY_TOKEN
LOCATION_ID
BASE_URL

### 🚀 Deployment
Backend → Azure Functions
Frontend → Azure Static Web Apps
CORS configured for frontend domain

### 📚 Future Enhancements
- Real Slack integration
- Per-variant risk model
- Retry handling for Shopify 429
- Real-time webhooks

### 📅 Version History
2025-11-28 — Initial implementation
