// <auto-generated />
namespace BR.Soccer.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class InitialCreate : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201206040106127_InitialCreate"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAO1dW2/juBV+L9D/YOipLbC2wwKL2YGzi5nMZBG0uSBO59VgbMYRqosryUHy2/rQn9S/UOpO8U6KkpUiL0Eskkfn8vFyyMOj//77P6vfXsNg9oKS1I+jc+9svvRmKNrGOz/an3vH7OmnT95vv/7xD6vvu/B19qOuB/J6uGWUnnvPWXb4vFik22cUwnQe+tskTuOnbL6NwwXcxQuwXH5anC0XCJPwMK3ZbHV/jDI/RMUP/PMijrbokB1hcB3vUJBWz3HJuqA6u4EhSg9wi869r/fzdbzdomRe1vVmXwIfYj7WKHgyZGr5S86U17wOv/A7Zix7e3g7oOKl595DfEwi/F+UkfVwzb+ht84D/OguiQ8oyd7u0RPT+mrnzRZdCguaREOA2zpn6ty7irK/Am92cwwC+BjgB08wSJE3O/z8eZ3FCfodRSiBGdrdwSxDCTbW1Q4VQlXK+Xz4WU8/vyyWINfPAkZRnMEMW54RgWI4/1szus4SDCJvdum/ot3fUbTPnhtmr+Fr/QT/683+EfkYc7hRlhwRKVz5W/7SNebtmP6AgUpFFJkb+OLvC7FYgnuEgXWPgqI4ffYPJb7mrUU2da3LJA7v46Bjrqpws8ZPtrlGYlGNB5jsUdblbbVoUSjFZkHDBpZFQxtENg0/wMh/6W2yQ4khEOlej9uao3noTvF7Eh8P/E5RgGJTV2j7A/mc6QqdQl4vkDKTzwdcXvKSsm+RnLRPm1fVfBBFNYtWfbGQxKYvFg1t+mLT8KMvqvDygGAowEuuxE1VTgCmfcwglyzrNXwXhHI61rDJG1tDp248RfhILSk2ZF66KatQtmxK+OZsi02HorsAvqHkTMFTU4vHVlUo4ayuYccc0GIOyJgDSuZAv75g2w1se8CUwT/+2KltptLWNoYqW9qYqm35YSwjY+VLG6upBf+1mlWqdu/ATHn3P1tvMRs91+oNnTsU9ScFHLEE3LB0ld4+1BS+xnjYh9Hp"
                       + "HZFC5eK1f1VMrf2Lp+wc1haZzqxFK+nc39Dmzf10oYQ127mfaCxYAFCvADIOOQsApoYNhwrW+DxJmLHkQsuSQGZJoLQk6GNJoGVJILMkUFoS2Fqycrht/HEuM11XXWfy+5Km8dYv3k77OBvO2vJ7tJvJvYNyBu8slPGsfQwy/xD4W8zBufcXRkFCss2uQ0uWR3E5n5/R8hKS6Qpc41TNHANaZ2LTYCcoV4vIIWUH2rKDwWQHY8pebWFIeaP3Myh51UwJSXIE1VWhgaCdfUYRW/xNx5avaiwyEpW7V6lSn72cxDpGqHzOoobgp3BCDJDLroMGHaiYpZGaMdlAZS3tyGMUs97S5ZA/RvUUe7ThqV3LKVlzKyhXwuHQDLTRzK4VXUh7IjQDbTSzC1B3Yo+KZt65K8UatbjtKSh1dGU8mxkIyJ5wiziTHHcT3a0NnzCbc8VH5SrxdSfe0pG4iKMM+hFKKvm/wQzmz9ArHfBR1l+jjNFU6s1ar4QjOCNkl1AdScDQqMRTNK8PXpnm1bJEp3l1AMYnUQ6ZCjIiClqNy47Ka153YZUQ5YEwy3/R26jGBB44aqjOj4hK/BMmeh9V6VI2PHd1vtAmVHcAghCXRgfxuJqR9M0eh0wB3JlO08XsowZ6iiNoNRByrgugowtgoAvgUBdgBF3Ux+MCLfBcT6XzSUuuITXla2rpzkLkbjQLK7PYC1X7oQTP9aAvkZrrdioVZ2NlYuOcY2SBO6pySElOy+FZZmHWBR1imGM35WXyagxzQgfVUvpxRjh251+tBukIJ3RYe6lh6MGNOGWQyK8leF+JuaI6hz3QgT3fj9X0ZC2lHxf2QAf2fL9W07PtpYYxYF+5FgL5OQ6uysU1l7jr1CqnRgtJOdHarMAKh1fT5SV7LekXSpQg9nD76KI+IGv82qZstShvU1QPVgvBtYvVNTwc/GhPXMOonszW5R2Mi5/W5jctwpLGYttRMO2FN2/K4gRLTpXiV2NOL/0k"
                       + "zXI//RHmgQMXu5CppuHF129inXnWZLVXWbfJ/y/b0ddR5qL7IqQeL7FoeY1CSsSFDtt4lt+GgQFMpJdELuLgGEbqyycyimUME0nphuNGyygQQR8kGeIxS2u1oLRDm2HB2IHqE7RptQwv7PMGNucOlxrmFrSTaLW8fEHplHeVY1j7VrccSBLVI30azTWHDmTrh/+XWBM6jQZY49wzKIiosCZoJ9Jqc7mA1KngqoKMjj7WTmkT0Q6GqV14G4O6tuG3ldqnDmJmbFQXTEbLDhRsqVsztfI0KlbmuwV97Uz0MggvFlzLJKKGInW2AeCkSkUB5e/aMKXr1G8ggnTUt5ZR+M2Eww8MmZUIP2xcRqXY6qlCnukeVz+3oVYEPvMJFkVmNIGAQ2DFIRBzCGw4LGO0SVLlk/e9gOq6t4IZuzqp05mUq6raE2/upotm3M5hHKsZo3llI5pccgU1HBgzV+1KaDJnt5aQcoh9751fRBVcpXmkfxPlr6kAeoOjB0iaLU8tnDS13UCF2tfUNIhswjvbiCc+a9BQu7gTx41KEc7BA4zAA9yCBzgEDxgOPOBdgUesCDfgqY/MVbCp6/UGTPd43cQGXP1vhK6+DUy6J/cTB4hU/t7o6EYXqPYUm4pauzkc9fOiEDT1L95t3Aj3HA3BwQtw6A3dYVAhFbz/mAHbAAyFa1dX0/HfeP0R0nEWPVewZ86WsJCOINGFgoEv6mbRKpLZIQ60Vq1s7d6ocLlg7RB0t/BgeJ08XIZfsEImoMcAN7wFqx1u3KxVOwQHw43xgvVUuBlyrQrbCCgdwDhAiilERPMOcD7vTB8QIpkd4sBo3gHO5h06AKz3+AGGm3fomLfpwmW8eQcYzTvA2bxDR8y5ws0Q8w4dJDh13Aw971QhiCrAVNX6IKUTaTgd95eNopwkJIZ1fTkxmlrRdU1traAqjvaFsZy6CxONuLuNPATPEC/CgNHekB5oLNHTgxpCTEwrXaU5jqyeNL+bmNYq"
                       + "nlSdX5wJMC2reDOsihd/lweXrt/SDIXzvMJ8/a/gIvCLW551hWsY+U8ozR7if6I8V/py+ck+SXmT2yxNd8H7ylTu50pRpnozTCeW/61fEL3AZPsMkz+F8PXPvbOGF+xKuXk/ebmnrfpOjmy12jlo62bItiFhYX4Z6jfCDuAmk+Opk0tPG1DUCmUQ7bOHcafJ0zyIJTqRGJrqY6mw7mZPUsAFKeo8zzU4bHFhC4kR0GDZL99VEuF3qTjW5x0zoe9gI083Ea/VRNyN7+xHCDhhh0nBa0OITMD76J9qldM58bQehwUnYS7oOZknuhvs/cg4FpOzIWdNz+1ayU3+KDcZo4j9RIP0UJgEHihRko9fMLiIozRLoM8GNN8lfrT1DzBguWe3X8zc61y9DXm65Bs6oCgfXTtSmr1SuQ3VvISaIFSaGSR5Z+90nVXeK8MEnbZA0DeIZKtN2/yi63+Ct8n2qkcwumYO5jaO3yhJI2t0hpBBIl+7UYB/KU13uW9ueqMXSo7IRzW+KjFmneTNInXjBDAgvAen778MiAOdc/ATgEGcLvQDDEODQX64PRYYdDKWu0lSPjoI9CdpScTyQBBQhvePYX+oTHDuZElAbMcY5N6d/kKAE/ogfJcsPntUU4+2CBjR6qOP9kaWn8rUD+lw4w8IjAuB00/4sAkg/hjwB7a5LDB6VFN/DPgj93atmOcTQOBjwB8bAtMY8OWfyXC01zui5Ufe6dW1+/gbvVQ0ZsUHm5qTNpro+xmKz2eUEZjn3u4xxqYuj6gkSVb539cQf16DR16QdpWmXG1JMJSr5zzKgqTtXMrlEohPvSwTvqHKK6B4i+AFYtp6ZOsxnCFcF/BIixIcM5opOjirlOIxVx+Qk4549ITBghTBnP7KDJFMcLsigFpDUJcfOVAzyNvYI69ycL9T0+fDHSWAe3zChewYbRpBpVhMM/H3cybwjZZuNyVT801L0N4fYJm0oE6+rqLuT2OL1m7x2n5SxKIP"
                       + "ElNDe0nMpTCyniff6XQByJHE6/05kImKZ/+ZjwlC0dWnPKZqKx0oanyiY4Li9fv0htWSq6c4Bt+UYO/ZYT/ziFuHZdwgdnNTf9+SyG8SRmjb8TCbOlfRU1z7uxRHdRUquvEaZXCH3c8vSeY/wW2Gi7coTf1o781+wOCIq3wPH9HuKro9ZodjhkVG4WPwRiojd5hl7y8+nNHleXV7yH+lLkTAbPpYBHQbfT36wa7h+5JzIU1AIvfEqxjt3JZZHqu9f2so3cSRJqFKfc0GwgMKDwEmlt5Ga/iCxLypddjV2OqbD/cJXuhUNNr2+CeG3y58/fV/ZvLET6+WAAA="; }
        }
    }
}
