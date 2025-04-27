// SPDX-License-Identifier: MIT
pragma solidity ^0.8.21;

contract MemoContract {
    string public memo;

    function setMemo(string calldata _memo) public {
        memo = _memo;
    }

    function getMemo() public view returns (string memory) {
        return memo;
    }
}