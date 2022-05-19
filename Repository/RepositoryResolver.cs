using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public static class RepositoryResolver {

        public static String ConnectionString = "server=localhost; database=lg4; user=root; password=0816";

        public static DataContext GetContext() {

            return new DataContext();

        }

    }
}
