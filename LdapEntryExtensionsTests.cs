using Novell.Directory.Ldap;

namespace TestProject1
{
    public class LdapEntryExtensionsTests
    {
        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void LdapAddressBookContactTest(LdapAttribute attribute)
        {
            Assert.True(true);
        }

        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[]
            {
                GetLdapAttribute()
            };
        }
        private static LdapAttribute GetLdapAttribute()
        {
            return new LdapAttribute("objectGUID", Guid.NewGuid().ToByteArray());
        }
    }
}