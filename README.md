# Kitchen Simulator
## Project Description

The **Kitchen Simulator** is a high-fidelity engine designed to model the complex lifecycle of food service operations. Moving beyond standard CRUD functionality, this project serves as a **Technical Research & Development (R&D) Manifesto**. It is a deliberate "over-engineered" sandbox designed to push the boundaries of distributed systems, high-performance computing, and multi-paradigm data modeling.

The core mission is to master "The Edge"—the threshold where standard software solutions fail and specialized architectural engineering becomes a necessity.

## Project Scope

For the initial phase, the simulator focuses on the transition from order placement to completion, factoring in real-world constraints through a high-precision lens:

* **Asynchronous Orchestration:** Simulating real-world time passage (e.g., bread toasting) using non-blocking, asynchronous execution threads.
* **State Integrity:** Implementing a strict state machine (*Order -> Ingredient Check -> In Progress -> Completed*) with full event-sourced traceability.
* **Dynamic Algorithmic Estimation:** Calculating preparation time through a multi-variable formula.
* **Inventory Simulation:** Validating stock availability with automated fallback states (e.g., "In Search of Ingredients") to test system resilience.

## Project Technical Overview

The system architecture is built on three foundational pillars designed for high-stress testing:

### 1. Multi-Runtime Core
* **Orchestrator (.NET):** Manages Domain-Driven Design (DDD) patterns, business rules, and high-level state.
* **Computational Engine (Rust):** A low-latency core responsible for the physics of time simulation and high-concurrency execution.
* **Reactive Gateway (TypeScript):** Handles the real-time event stream and provides a type-safe interface for distributed modules.

### 2. Polyglot Persistence
The data strategy utilizes specialized engines for specific domain problems:
* **Relational (SQL):** Ensuring ACID compliance for financial and order finalization data.
* **Document (NoSQL):** Storing dynamic, schema-less recipe steps and chef profiles.
* **Graph (Neo4j):** Mapping complex ingredient dependencies and supply chain bottlenecks.
* **Data Warehouse:** Aggregating historical metrics for performance auditing and bottleneck heat-mapping.

### 3. Infrastructure & DevOps
* **Azure Cloud:** Utilizing Service Bus for asynchronous messaging and Load Balancers for horizontal scaling.
* **Observability:** Integrated telemetry for monitoring "Thread Health" and "Event Latency."
* **CI/CD:** Fully automated pipelines supporting deployments across staged environments.

## Project Stack
* **Backend:** .NET 10 (C#), Rust
* **Frontend/API:** TypeScript
* **Messaging:** Azure Service Bus/RabbitMQ.
* **Databases:** PostgreSQL, NoSQL (MongoDB/CosmosDB), Neo4j

## Project Setup

> *This section is currently under development. Detailed instructions for environment variables, Docker containers, and multi-runtime compilation will be added here.*

1. **Prerequisites:** Ensure you have .NET 10 SDK, Rust (Cargo), and Node.js installed.
2. **Clone the Repo:** `git clone https://github.com/m4ert/KitchenSimulator.git`
3. **Local Infrastructure:** Run `docker-compose up` to spin up the SQL, NoSQL, and Graph instances.
