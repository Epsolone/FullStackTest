import { TransactionType } from './transaction-type';

export default class Transaction {
    id = "";
    accountId = "";
    createDate = new Date();
    type: TransactionType = TransactionType.Empty;
    amount = 0;

    static parseJson(json: any) {
        if (json === null || json === undefined) return json;

        const { createDate, ...rest } = json;

        return Object.assign(
            new Transaction(),
            {
                createDate: new Date(createDate)
            },
            rest);
    }
}