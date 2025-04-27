
# Ethereum Architecture
<br>

## 1. What is Ethereum?

### A **programmable blockchain platform** that allows the execution of **`smart contracts`** and supports **`decentralized applications (DApps)`**.

- Unlike Bitcoin (which only supports transactions), Ethereum enables **code execution on-chain**.
- Launched in **2015** by **Vitalik Buterin** and others.

---
<br>

## 2. Key Components of Ethereum

### 2-1. Ethereum Virtual Machine (EVM)

- A **`virtual computer`** that executes smart contracts.
- Ensures **`all nodes`** on the network **`execute the same code`** in the same way.
- Isolated environment — contracts cannot access external systems directly.

---

### 2-2. Accounts

| Account Type                  | Description                      |
|-------------------------------|----------------------------------|
| **Externally Owned Account (EOA)** | Controlled by a private key (users) |
| **Contract Account**          | Controlled by smart contract code |

- Both account types can **hold ETH and interact with contracts**.

---

### 2-3. State and State Trie

- Ethereum tracks the **global state** (balances, contract storage, etc.).
- Stored in a **Merkle Patricia Trie** (a special tree structure).
- Allows efficient verification of state changes.

---

### 2-4. Gas

- The **fuel** required to run operations on Ethereum.
- Prevents spam, infinite loops, and ensures fair resource usage.
- Users pay **Gas Used × Gas Price = Fee (in ETH)**.

---
<br>

## 2. Ethereum Block Structure

| Block Component | Description                          |
|-----------------|--------------------------------------|
| **Header**      | Metadata (block number, hashes, etc.)|
| **Transactions**| List of transactions in the block    |
| **State Root**  | Root hash of the global state trie   |
| **Receipts**    | Logs of events emitted by contracts  |

---
<br>

## 3. Ethereum vs Bitcoin (Comparison)

| Feature              | Ethereum                                  | Bitcoin                      |
|----------------------|--------------------------------------------|------------------------------|
| **Purpose**          | Programmable platform for DApps           | Digital currency             |
| **Smart Contracts**  | Supported                                 | Not supported                |
| **Consensus (current)** | Proof of Stake (PoS)                    | Proof of Work (PoW)           |
| **Block Time**       | ~12-15 seconds                            | ~10 minutes                  |
| **State Storage**    | Full global state (balances, contracts)   | Only UTXO set (unspent outputs) |