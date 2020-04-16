import Transaction from '@/models/transaction';
import Axios, { AxiosRequestConfig, AxiosInstance } from 'axios';

class TransactionsService {
    private httpClient: AxiosInstance;    
    private BASE_URL = "http://localhost:5000"

    constructor() {
        this.httpClient = Axios.create();
    }

    async GetTransactionsHistory(): Promise<Transaction[]> {
        const config = {
            baseURL: this.BASE_URL,
            url: '/api/transaction',
            method: "GET",
            headers: { "Content-Type": "application/json", "Access-Control-Allow-Origin": "*" }
        } as AxiosRequestConfig;

        const response = await this.httpClient.request(config);

        return response.data.map(Transaction.parseJson);
    }
}

export const transactionsService = new TransactionsService();