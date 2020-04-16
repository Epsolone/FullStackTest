import { Vue, Component } from "vue-property-decorator";
import Transaction from '@/models/transaction';
import { transactionsService } from '@/services/transactions-service';
import { TransactionType } from '@/models/transaction-type';

@Component
export default class AccountTransactions extends Vue {

    private transactions: Transaction[] = [];

    async mounted() {
        this.transactions = await transactionsService.GetTransactionsHistory();
    }

    getTransactionClass(transaction: Transaction): string {
        switch (transaction.type) {
            case TransactionType.Credit:
                return "success"
            case TransactionType.Debit:
                return "danger"
            default:
                return "secondary"
        }
    }
}