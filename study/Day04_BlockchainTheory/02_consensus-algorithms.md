# Consensus Algorithms
<br>

## 1. What is a Consensus Algorithm?

### A method to **`agree on a single valid version`** of the blockchain among distributed nodes.

- Prevents conflicts when multiple participants suggest different blocks.
- Ensures that **only one chain of truth** exists in the network.

---
<br>

## 2. Why is Consensus Important?
Because blockchain is structured as a sequence of blocks linked together in order, it is essential to determine the correct block order and prevent conflicts between competing blocks.

| Purpose               | Description                                     |
|-----------------------|-------------------------------------------------|
| **Maintain order**    | Decides which block is added next               |
| **Prevent conflicts** | Resolves disputes between competing blocks      |
| **Ensure security**   | Protects against attacks (e.g., double spending)|

---
<br>

## 3. Types of Consensus Algorithms

#### Key Terms: `Miners` and `Validators`

- **Miner**: In Proof of Work (PoW) systems, a miner is a participant who competes to solve complex mathematical puzzles. The winner gets to create the next block and earns rewards.

- **Validator**: In Proof of Stake (PoS) systems, a validator is a participant selected to create the next block based on the amount of cryptocurrency they stake as collateral.

---

### 3-1. PoW (Proof of Work)

- **Miners** compete to solve a complex mathematical puzzle.
- The first to solve it **earns the right to create the next block**.
- Example: Bitcoin, Ethereum (before Ethereum 2.0).

**Pros:** Strong security, proven model.  
**Cons:** High energy consumption.

---

### 3-2. PoS (Proof of Stake)

- **Validators** are chosen based on how many tokens they stake.
- The more you stake, the higher your chance to validate the next block.
- Example: Ethereum 2.0, Cardano.

**Pros:** Energy efficient, scalable.  
**Cons:** Wealth concentration risk (the rich get richer).

---

### 3-3. DPoS (Delegated Proof of Stake)

- Token holders **vote for a few delegates** who produce blocks on their behalf.
- Example: EOS, TRON.

**Pros:** Fast, scalable.  
**Cons:** More centralized.

---

### 3-4. PBFT (Practical Byzantine Fault Tolerance)

- Nodes **communicate and vote** to reach consensus.
- Works well in **permissioned (private) blockchains**.
- Example: Hyperledger Fabric.

**Pros:** Fast, low energy use.  
**Cons:** Only suitable for smaller networks.

---

### Summary Table

| Algorithm | Mechanism              | Pros                  | Cons                 | Used by Ethereum? |
|-----------|--------------------------|-----------------------|----------------------|-------------------|
| **PoW**   | Solve puzzles            | Secure, proven        | Energy intensive     | Previously used   |
| **PoS**   | Stake tokens             | Efficient, scalable   | Wealth concentration | Currently used    |
| **DPoS**  | Vote for delegates       | Fast, scalable        | More centralized     | No                |
| **PBFT**  | Voting among nodes       | Fast, low energy usage| Limited scalability  | No                |