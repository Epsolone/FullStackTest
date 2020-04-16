<template>
    <b-container>
        <div role="tablist" v-if="transactions.length > 0">
            <b-card no-body class="mb-1" v-for="item in transactions" :key="item.id">
              <b-card-header header-tag="header" class="p-1" role="tab">
                <b-button
                    block
                    href="#"
                    v-b-toggle="`accordion-${item.id}`"
                    :variant="getTransactionClass(item)">{{item.type}}: {{item.amount}}</b-button>
              </b-card-header>
              <b-collapse 
                :id="`accordion-${item.id}`"
                accordion="my-accordion"
                role="tabpanel">
                <b-card-body>
                  <b-card-text><code>{{item.type}}</code> Trancastion for <code>{{item.amount.toFixed(2)}}</code> created <code>{{item.createDate.toLocaleString()}}</code></b-card-text>
                </b-card-body>
              </b-collapse>
            </b-card>
        </div>
        <div v-else>
          <b-card no-body class="mb-1">
              <b-card-header header-tag="header" class="p-1" role="tab">
                <b-button
                    block
                    href="#"
                    v-b-toggle="'accordion-empty-list'"
                    variant="secondary">Transaction list empty</b-button>
              </b-card-header>
              <b-collapse 
                id="accordion-empty-list"
                accordion="my-accordion"
                role="tabpanel">
                <b-card-body>
                  <b-card-text>To see Transactions here you need make api call</b-card-text>
                  <b-card-text>Url: <code>{api}/transaction</code></b-card-text>
                  <b-card-text>Method: <code>POST</code></b-card-text>
                  <b-card-text>Headers: <code>Content-Type: application/json</code></b-card-text>
                  <b-card-text>Body: <code>{ type: 'credit|debit', amount: 0.0 }</code></b-card-text>
                </b-card-body>
              </b-collapse>
            </b-card>
        </div>
    </b-container>
</template>
<script src="./account-transactions.ts" />