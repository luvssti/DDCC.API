using System.ComponentModel.DataAnnotations;

namespace DDCC.API.Model
{
    public class monthly_data
    {
        [Key]
        public int stat_id {get; set; }
        public int 	stat_year {get; set; }
        public int 	stat_month {get; set; }
        public int 	consumer_count {get; set; }
        public double 	ps_total_interruption {get; set; }
        public int 	ps_duration_interruption {get; set; }
        public int 	ps_int_duration {get; set; }
        public double 	ps_mom_interruption {get; set; }
        public double 	ps_saifi {get; set; }
        public double 	ps_saidi {get; set; }
        public double 	ps_maifi {get; set; }
        public double 	ps_caidi {get; set; }
        public double 	sch_total_interruption {get; set; }
        public int 	sch_duration_interruption {get; set; }
        public int 	sch_int_duration {get; set; }
        public double 	sch_mom_interruption {get; set; }
        public double 	sch_saifi {get; set; }
        public double 	sch_saidi {get; set; }
        public double 	sch_maifi {get; set; }
        public double 	sch_caidi {get; set; }
        public double 	uns_total_interruption {get; set; }
        public int 	uns_duration_interruption {get; set; }
        public int 	uns_int_duration {get; set; }
        public double 	uns_mom_interruption {get; set; }
        public double 	uns_saifi {get; set; }
        public double 	uns_saidi {get; set; }
        public double 	uns_maifi {get; set; }
        public double 	uns_caidi {get; set; }
        public double 	monthly_powerfactor {get; set; }
        public double 	monthly_loadfactor {get; set; }
        public double 	monthly_purchase {get; set; }
        public double 	monthly_sales {get; set; }
        public double 	monthly_system_loss {get; set; }
        public double 	monthly_gen_cost {get; set; }
        public double 	monthly_demand {get; set; }
    }
}
