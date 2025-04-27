# Blockchain Basics
<br>

## 1. What is Blockchain?
### A system that **`shares and verifies immutable transaction records`** among multiple participants.

- Block + Chain
- Each block contains **transaction records** and the **hash of the previous block**.

---
<br>

## 2. Block Structure
| Item                  | Description                                   |
|-----------------------|-----------------------------------------------|
| **Transaction list**  | Transactions included in this block           |
| **Previous block hash** | Links the current block to the previous one  |
| **Current block hash**  | Unique identifier calculated from block data |
| **Timestamp**         | Time when the block was created               |
| **Difficulty, Nonce** | Values used for Proof of Work (PoW)            |

---
<br>

## 3. Chain Structure and the Role of Hashes
- Blocks are **linked like a chain**:
  - Block A ➡️ Block B ➡️ Block C
  - Block B contains the **hash of Block A**, Block C contains the **hash of Block B**.
- If anyone tries to modify Block A, the hashes of **Block B and C would change**.
- This makes **modification practically impossible**.

---
<br>

## 4. Distributed Ledger

### The transaction record is **`shared across many participants`**, not held by a single entity.

- **No central server** — every node holds the **same copy of the ledger**.
- To tamper with the system, an attacker would need to **control a majority of the network nodes** at the same time.