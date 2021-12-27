﻿namespace Bit.Core.AccessPolicies
{
    public abstract class BaseAccessPolicies
    {
        protected static AccessPolicyResult Success => AccessPolicyResult.Success;
        protected static AccessPolicyResult Fail() => AccessPolicyResult.Fail();
        protected static AccessPolicyResult Fail(string blockReason) => AccessPolicyResult.Fail(blockReason);
    }
}