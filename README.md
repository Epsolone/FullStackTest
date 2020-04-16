# Accounting app

# Start api
- open CMD in root folder (folder with sln file);
- run command: `dotnet run --project BackEndApplication\BackEndApplication.csproj --launch-profile BackEndApplication`

# Start client
- open CMD in {root folder (folder with sln file)}/FrontEndApplication
- run command: `npm install`
- run command: `npm run serve`

# Create transaction
- Description: Endpoint add transaction to the account
- URL: `/transaction`
- Method: `POST`
- Headers: `Content-Type: application/json`
- Body: `{ type: 'credit|debit', amount: 0.0 }`
