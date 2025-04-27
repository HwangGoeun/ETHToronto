// SPDX-License-Identifier: MIT
pragma solidity ^0.8.21;

import {Script} from "forge-std/Script.sol";
import {MemoContract} from "../src/MemoContract.sol";

contract DeployMemo is Script {
    function run() external {
        vm.startBroadcast();
        new MemoContract();
        vm.stopBroadcast();
    }
}